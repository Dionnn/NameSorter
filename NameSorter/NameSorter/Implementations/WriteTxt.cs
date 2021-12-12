using NameSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSorter.Implementations
{
    public class WriteTxt : IWriteTxt
    {
        private string _pathFileName;
        private StringBuilder _sbText;

        public WriteTxt(string pathFileName, StringBuilder text)
        {
            this._pathFileName = pathFileName;
            this._sbText = text;
        }

        public void Write()
        {
            if (!string.IsNullOrEmpty(_pathFileName) && _sbText != null)
            {
                if (File.Exists(_pathFileName))
                {
                    using (StreamWriter writer = new StreamWriter(_pathFileName, false))
                    {
                        writer.Write(_sbText.ToString());
                    }
                }
            }
        }
    }
}
