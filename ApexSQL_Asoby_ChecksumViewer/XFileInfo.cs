using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexSQL_Asoby_ChecksumViewer
{
    public class XFileInfo
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public double Size { get; set; }
        public String Checksum { get; set; }
        public String Attributes { get; set; }
        public String DateCreated { get; set; }

        public XFileInfo() { }
        public XFileInfo(String _Name, String _Path, double _Size, String _Checksum, String _Attributes, String _DateCreated)
        {
            Name = _Name;
            Path = _Path;
            Size = _Size;
            Checksum = _Checksum;
            Attributes = _Attributes;
            DateCreated = _DateCreated;
        }

        public override string ToString()
        {
            return Name + " " + Path + " " + Size.ToString() + "bytes; " + Checksum + "\n";
        }

    }
}
