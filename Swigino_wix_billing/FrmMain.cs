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
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

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

        
        public class Foo
        {
            public string OrderNo { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string BillingCustomer { get; set; }
            public string BillingCompanyName { get; set; }
            public string BillingCountry { get; set; }
            public string BillingState { get; set; }
            public string BillingCity { get; set; }
            public string BillingStreetNameNumber { get; set; }
            public string BillingZipCode { get; set; }
            public string DeliveryCustomer { get; set; }
            public string DeliveryCompanyName { get; set; }
            public string DeliveryCountry { get; set; }
            public string DeliveryState { get; set; }
            public string DeliveryCity { get; set; }
            public string DeliveryStreetNameNumber { get; set; }
            public string DeliveryZipCode { get; set; }
            public string BuyersPhoneNo { get; set; }
            public string ShippingLabel { get; set; }
            public string BuyersEmail { get; set; }
            public string DeliveryMethod { get; set; }
            public string ItemsName { get; set; }
            public string ItemsVariant { get; set; }
            public string SKU { get; set; }
            public string Qty { get; set; }
            public string ItemsPrice { get; set; }
            public string ItemsWeight { get; set; }
            public string ItemsCustomText { get; set; }
            public string Coupon { get; set; }
            public string NotestoSeller { get; set; }
            public string Shipping { get; set; }
            public string Tax { get; set; }
            public string GiftCard { get; set; }
            public string Total { get; set; }
            public string Currency { get; set; }
            public string PaymentMethod { get; set; }
            public string Payment { get; set; }
            public string Fulfillment { get; set; }
            public string Refund { get; set; }
            public string Totalafterrefund { get; set; }
            public string Qtyrefunded { get; set; }
            public string Qtyrestocked { get; set; }
            public string AdditionalInfo { get; set; }
        }

        public class FooMap : ClassMap<Foo>
        {
            public FooMap()
            {
                Map(m => m.OrderNo).Name("OrderNo");
                Map(m => m.Date).Name("Date");
                Map(m => m.Time).Name("Time");
                Map(m => m.BillingCustomer).Name("BillingCustomer");
                Map(m => m.BillingCompanyName).Name("BillingCompanyName");
                Map(m => m.BillingCountry).Name("BillingCountry");
                Map(m => m.BillingState).Name("BillingState");
                Map(m => m.BillingCity).Name("BillingCity");
                Map(m => m.BillingStreetNameNumber).Name("BillingStreetNameNumber");
                Map(m => m.BillingZipCode).Name("BillingZipCode");
                Map(m => m.DeliveryCustomer).Name("DeliveryCustomer");
                Map(m => m.DeliveryCompanyName).Name("DeliveryCompanyName");
                Map(m => m.DeliveryCountry).Name("DeliveryCountry");
                Map(m => m.DeliveryState).Name("DeliveryState");
                Map(m => m.DeliveryCity).Name("DeliveryCity");
                Map(m => m.DeliveryStreetNameNumber).Name("DeliveryStreetNameNumber");
                Map(m => m.DeliveryZipCode).Name("DeliveryZipCode");
                Map(m => m.BuyersPhoneNo).Name("BuyersPhoneNo");
                Map(m => m.ShippingLabel).Name("ShippingLabel");
                Map(m => m.BuyersEmail).Name("BuyersEmail");
                Map(m => m.DeliveryMethod).Name("DeliveryMethod");
                Map(m => m.ItemsName).Name("ItemsName");
                Map(m => m.ItemsVariant).Name("ItemsVariant");
                Map(m => m.SKU).Name("SKU");
                Map(m => m.Qty).Name("Qty");
                Map(m => m.ItemsPrice).Name("ItemsPrice");
                Map(m => m.ItemsWeight).Name("ItemsWeight");
                Map(m => m.ItemsCustomText).Name("ItemsCustomText");
                Map(m => m.Coupon).Name("Coupon");
                Map(m => m.NotestoSeller).Name("NotestoSeller");
                Map(m => m.Shipping).Name("Shipping");
                Map(m => m.Tax).Name("Tax");
                Map(m => m.GiftCard).Name("GiftCard");
                Map(m => m.Total).Name("Total");
                Map(m => m.Currency).Name("Currency");
                Map(m => m.PaymentMethod).Name("PaymentMethod");
                Map(m => m.Payment).Name("Payment");
                Map(m => m.Fulfillment).Name("Fulfillment");
                Map(m => m.Refund).Name("Refund");
                Map(m => m.Totalafterrefund).Name("Totalafterrefund");
                Map(m => m.Qtyrefunded).Name("Qtyrefunded");
                Map(m => m.Qtyrestocked).Name("Qtyrestocked");
                Map(m => m.AdditionalInfo).Name("AdditionalInfo");
            }
        }

        private void readCsvToDataset(string csvPath)
        {
            // Ganzes File in String/Memory lesen
            string fileContent = File.ReadAllText(csvPath, Encoding.UTF8);
            // Div. Replacements vornehmen (turns the malformed CSV into a wellformed CSV)
            if (htReplace != null)
                // Remove/ replace unwanted characters in CSV
                foreach (DictionaryEntry d in htReplace)
                {
                    fileContent = fileContent.Replace(d.Key as string, d.Value as string);
                }
            // Neuen Stringreader mit Content von bearbeitetem File generieren, als Basis für CsvHelper
            var reader = new StringReader(fileContent);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            {
                // Replacements im CSV-Header
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.Replace("#","No").Replace(" ", "").Replace("&", "").Replace("'", "");

                // Register the map-definition with our class
                csv.Configuration.RegisterClassMap<FooMap>();
                var records = csv.GetRecords<Foo>();

                var source = new BindingSource();
                source.DataSource = records;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = source;

                // dataGridView1.DataSource = records;
                //dataGridView1.addR
            }
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
            readCsvToDataset(sWixCsvFileAndPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FrmRdlcBill()).ShowDialog();

        }

        private void btnImportFromCsv_Click(object sender, EventArgs e)
        {

        }
    }
}
