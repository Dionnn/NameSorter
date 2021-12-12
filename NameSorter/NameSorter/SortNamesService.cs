using NameSorter.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortNamesService : ISortnamesService
    {
        private string _pathFileName;

        public SortNamesService(string pathFileName)
        {
            this._pathFileName = pathFileName;
        }

        public StringBuilder Sort()
        {
            StringBuilder sb = new StringBuilder();

            List<List<string>> listNames = new List<List<string>>();

            listNames = new ReadTxt(_pathFileName).Read();

            if (listNames.Count > 0)
            {
                listNames = listNames.OrderBy(x => x[x.Count - 1]).ToList();

                for (int i = 0; i < listNames.Count; i++)
                {
                    int idx = 0;
                    string name = string.Empty;
                    while (idx < listNames[i].Count)
                    {
                        name += listNames[i][idx] + " ";
                        idx++;
                    }
                    name.Trim();
                    sb.AppendLine(name);
                }
            }

            return sb;
        }
    }
}
