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
    public class CreateTxt : ICreateTxt
    {
        private string _filename;

        public CreateTxt(string fileName)
        {
            this._filename = fileName;
        }

        public string Create()
        {
            string pathFileName = string.Empty;

            if (!string.IsNullOrEmpty(_filename))
            {
                var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
                var dir = Path.Combine(assemblyParentPath, "FileNotes");
                pathFileName = dir + "\\" + Path.GetFileName(_filename);

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                if (!File.Exists(pathFileName))
                    File.Create(pathFileName).Close();
            }

            return pathFileName;
        }
    }
}
