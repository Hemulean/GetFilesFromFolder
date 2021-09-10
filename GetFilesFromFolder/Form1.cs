using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFilesFromFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDirectory.Text = dlg.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var files = System.IO.Directory.GetFiles(txtDirectory.Text, 
                "*."+cmbExtn.Text, System.IO.SearchOption.AllDirectories);
            //*.* For all types
            //System.IO.SearchOption.AllDirectories - for all folders including sub folder in the folder whose path is mentioned in the textbox

            lstFiles.DataSource = files;

            MessageBox.Show(files.Count() + "files found");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
