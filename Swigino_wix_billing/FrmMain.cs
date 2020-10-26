using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Swigino_wix_billing.Properties;
using System.IO;
using System.Collections;

namespace Swigino_wix_billing
{
    public partial class FrmMain : Form
    {
        private string sWixCsvFileAndPath;

        Hashtable htReplace = new Hashtable();

        public FrmMain()
        {
            InitializeComponent();

            // Add Hash pairs to replacement hash table
            htReplace.Add(",\"\"\"", ",\"");
            htReplace.Add("\"\"\",", "\",");
        }

        public void readCsv(string csvPath)
        {
            var fileContent = string.Empty;

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            bool bHeader = false;

            CustomStreamReader reader = new CustomStreamReader (csvPath, Encoding.UTF8);
            reader.addStrReplacementHash(htReplace);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                fileContent = fileContent +line+ "\r\n";  // fileContent wieder Zeilenweise zu einem ganzen zusammenfügen für Test/Show

                if (!bHeader)
                {
                    tbFieldHeaders.Text = line;
                    bHeader = !bHeader;  // toggle
                }
                else
                {
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);

                    //fileContent = reader.ReadToEnd();
                }
            }

                //    fileContent = reader.ReadToEnd();

            // MessageBox.Show(fileContent, "File Content at path: " + sWixCsvFileAndPath, MessageBoxButtons.OK);
            tbValues1.Text = string.Join(",", listA);
            // tbValues2.Text = string.Join(",", listB);
            tbValues2.Text = fileContent;

        }

        private void btnFileDialogCsv_Click(object sender, EventArgs e)
        {

            dlgOpenCsv.InitialDirectory = sWixCsvFileAndPath;
            dlgOpenCsv.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dlgOpenCsv.FilterIndex = 1;
            dlgOpenCsv.RestoreDirectory = true;

            if (dlgOpenCsv.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                sWixCsvFileAndPath = dlgOpenCsv.FileName;

                // Show in Textbox
                tbPathToCsv.Text = sWixCsvFileAndPath;

                // Read Values
                readCsv(sWixCsvFileAndPath);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Settings.Default.wixOrdersCsvPath != null)
            {
                this.sWixCsvFileAndPath = Settings.Default.wixOrdersCsvPath;
                tbPathToCsv.Text = this.sWixCsvFileAndPath;
            }
            else
            {
                this.sWixCsvFileAndPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                tbPathToCsv.Text = "Choose WIX Orders CSV-File..";
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(this.sWixCsvFileAndPath))
            {
                // Copy current .CSV-Path to Settings
                Settings.Default.wixOrdersCsvPath = this.sWixCsvFileAndPath;

                // Save settings
                Settings.Default.Save();
            }
        }

        private void btnCsvProcessStart_Click(object sender, EventArgs e)
        {
            // Read Values
            readCsv(sWixCsvFileAndPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FrmRdlcBill()).ShowDialog();

        }
    }
}
