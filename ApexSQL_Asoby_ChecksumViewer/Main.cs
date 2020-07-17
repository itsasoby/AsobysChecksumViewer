using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace ApexSQL_Asoby_ChecksumViewer
{
    public partial class Main : Form
    {
        List<XFileInfo> Files = new List<XFileInfo>();

        public Main()
        {
            InitializeComponent();
            AlgorithmSelectorDD.SelectedIndex = 0;
            SortCritComboBox.SelectedIndex = 0;
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            int fileCount = OpenFolder();
            ParseFiles();
            FilesGridView.DataSource = Files;
            FilesGridView.Update();
        }
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileCount = OpenFolder();
            ParseFiles();
            FilesGridView.DataSource = Files;
            FilesGridView.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int OpenFolder()
        {
            Files.Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string Path = folderBrowserDialog.SelectedPath;
            ToolStripFolderPathText.Text = "Directory " + Path;

            string[] files = System.IO.Directory.GetFiles(Path, "*.*", SearchOption.AllDirectories);
            LogTextBox.Text += "Working in directory at " + Path + "\n------------------------\n";
            foreach (string filename in files)
            {
                 XFileInfo fTemp = new XFileInfo();
                 fTemp.Path = Path;
                 fTemp.Name = filename.Remove(0, Path.Length);
                 Files.Add(fTemp);
                 LogTextBox.Text += "Found a file at " + fTemp.Path + "\n";
            }
            return files.Count();
        }
        void ParseFiles()
        {
            int i = 0;
            LogTextBox.Text += "\n------------------------\nStarted examining files\n------------------------\n";
            foreach (XFileInfo xFile in Files)
            {
                i++;
                switch (AlgorithmSelectorDD.SelectedIndex)
                {
                    case 0: xFile.Checksum = CalculateMD5(xFile); break;
                    case 1: xFile.Checksum = CalculateSHA1(xFile); break;
                    case 2: xFile.Checksum = CalculateSHA256(xFile); break;
                    case 3: xFile.Checksum = CalculateSHA384(xFile); break;
                    case 4: xFile.Checksum = CalculateSHA512(xFile); break;
                }
                xFile.DateCreated = File.GetCreationTime(xFile.Path + xFile.Name).ToString();
                xFile.Size = new System.IO.FileInfo(xFile.Path + xFile.Name).Length;
                xFile.Attributes = GetAttributesFromFile(xFile);
                LogTextBox.Text += "File " + xFile.Name + " processed!\n";
            }
            FilesProcessedStatusLabel.Text = Files.Count + " files processed!";

        }
        string GetAttributesFromFile(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            string AttributeList = "";
            FileInfo f = new FileInfo(filename);
            FileAttributes fAttr = f.Attributes;
            if ((fAttr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) AttributeList += "ReadOnly ";
            if ((fAttr & FileAttributes.Hidden) == FileAttributes.Hidden) AttributeList += "Hidden ";
            if ((fAttr & FileAttributes.System) == FileAttributes.System) AttributeList += "System ";

            return AttributeList;
        }
        string CalculateMD5(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            LogTextBox.Text += "Calculating MD5 of file " + filename + "...\n";
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    LogTextBox.Text += "Done!\n";
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        string CalculateSHA1(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha1.ComputeHash(stream);
                    LogTextBox.Text += "Done!\n";
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        string CalculateSHA256(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha256.ComputeHash(stream);
                    LogTextBox.Text += "Done!\n";
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        string CalculateSHA384(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            using (var sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha384.ComputeHash(stream);
                    LogTextBox.Text += "Done!\n";
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        string CalculateSHA512(XFileInfo xFile)
        {
            string filename = xFile.Path + xFile.Name;
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha512.ComputeHash(stream);
                    LogTextBox.Text += "Done!\n";
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void exportCurrentTotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("log.txt", LogTextBox.Text);
        }

        private void exportChecksumListTotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Files.Count < 1) MessageBox.Show("You have to choose a directory first.");
            else
            {
                List<string> fileInfos = new List<string>();
                fileInfos.Add(AlgorithmSelectorDD.SelectedItem.ToString() + " checksums\n------------------------\n");
                foreach (XFileInfo file in Files)
                {
                    fileInfos.Add(file.ToString());
                }
                File.WriteAllLines("outputChecksums.txt", fileInfos);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            Files.Clear();
            FilesGridView.DataSource = null;
            FilesGridView.Rows.Clear();
        }

        private void Button_Filter_Click(object sender, EventArgs e)
        {
            List<XFileInfo> Files_Filtered = new List<XFileInfo>();
            List<XFileInfo> TFiles_Filtered = new List<XFileInfo>();
            int SortBy = SortCritComboBox.SelectedIndex;
            switch (SortBy)
            {
                case 0: Files_Filtered = Files; break;
                case 1: Files_Filtered = Files.OrderBy(o => o.Name).ToList(); break;
                case 2: Files_Filtered = Files.OrderBy(o => o.Size).ToList(); break;
                case 3: Files_Filtered = Files.OrderBy(o => o.DateCreated).ToList(); break;
                case 4: Files_Filtered = Files.OrderBy(o => o.Attributes).ToList(); break;
            }
            if (FltNameAndExtTextBox.Text != "")
            {
                foreach (XFileInfo xFile in Files_Filtered)
                {
                    if (xFile.Name.Contains(FltNameAndExtTextBox.Text))
                    {
                        TFiles_Filtered.Add(xFile);
                    }
                }
                Files_Filtered = TFiles_Filtered;
            }
            if (DescendingFilterCheckBox.Checked)
            {
                Files_Filtered.Reverse();
            }
            FilesGridView.DataSource = Files_Filtered;
            FilesGridView.Update();
            FilesGridView.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Stanislav Levchenko / Asoby, 2020.\nhttps://itsasoby.github.io/\nFor ApexSQL competency test only.\nThank you for your time and consideration!");
        }
    }
}
