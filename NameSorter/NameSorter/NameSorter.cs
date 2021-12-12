using NameSorter.Implementations;
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

namespace NameSorter
{
    public partial class NameSorter : Form
    {
        private string unsortedNamesPathFile = string.Empty;

        public NameSorter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Title = "Browse Text File";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog.FileName;
          
                if (openFileDialog.OpenFile() != null)
                {
                    StringBuilder sb = new StringBuilder();
                    string pathFileName = new CreateTxt(openFileDialog.FileName).Create();
                    sb = new StringBuilder(File.ReadAllText(openFileDialog.FileName));
                    new WriteTxt(pathFileName, sb).Write();
                    unsortedNamesPathFile = pathFileName;
                    rtbBefore.Text = File.ReadAllText(pathFileName);
                }
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            if (File.Exists(unsortedNamesPathFile))
            {
                StringBuilder sb = new StringBuilder();
                string sortedNamesPathFile = new CreateTxt("sorted-names-list.txt").Create();
                sb = new SortNamesService(unsortedNamesPathFile).Sort();
                new WriteTxt(sortedNamesPathFile, sb).Write();
                rtbAfter.Text = sb.ToString();
            }
        }
    }
}
