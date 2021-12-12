using NameSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Implementations
{
    public class ReadTxt : IReadTxt
    {
        private string _pathFileName;

        public ReadTxt(string pathFileName)
        {
            this._pathFileName = pathFileName;
        }

        public List<List<string>> Read()
        {
            List<List<string>> listNames = new List<List<string>>();

            if (!string.IsNullOrEmpty(_pathFileName))
            {
                string line = string.Empty;

                using (StreamReader sr = new StreamReader(_pathFileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        listNames.Add(line.Trim().Split(' ').ToList());
                    }
                }
            }

            return listNames;
        }      
    }
}
