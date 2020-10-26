namespace Swigino_wix_billing
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPathToCsv = new System.Windows.Forms.Label();
            this.tbPathToCsv = new System.Windows.Forms.TextBox();
            this.dlgOpenCsv = new System.Windows.Forms.OpenFileDialog();
            this.btnFileDialogCsv = new System.Windows.Forms.Button();
            this.btnCsvProcessStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbValues1 = new System.Windows.Forms.TextBox();
            this.tbValues2 = new System.Windows.Forms.TextBox();
            this.tbFieldHeaders = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPathToCsv
            // 
            this.lblPathToCsv.AutoSize = true;
            this.lblPathToCsv.Location = new System.Drawing.Point(12, 31);
            this.lblPathToCsv.Name = "lblPathToCsv";
            this.lblPathToCsv.Size = new System.Drawing.Size(88, 13);
            this.lblPathToCsv.TabIndex = 1;
            this.lblPathToCsv.Text = "&Path to WIX .csv";
            // 
            // tbPathToCsv
            // 
            this.tbPathToCsv.Location = new System.Drawing.Point(127, 28);
            this.tbPathToCsv.Name = "tbPathToCsv";
            this.tbPathToCsv.ReadOnly = true;
            this.tbPathToCsv.Size = new System.Drawing.Size(1056, 20);
            this.tbPathToCsv.TabIndex = 0;
            // 
            // dlgOpenCsv
            // 
            this.dlgOpenCsv.FileName = "orders.csv";
            this.dlgOpenCsv.Filter = "CSV-Files|*.csv|All Files|*.*";
            this.dlgOpenCsv.Title = "Path to WIX orders.csv";
            // 
            // btnFileDialogCsv
            // 
            this.btnFileDialogCsv.Location = new System.Drawing.Point(1202, 26);
            this.btnFileDialogCsv.Name = "btnFileDialogCsv";
            this.btnFileDialogCsv.Size = new System.Drawing.Size(32, 23);
            this.btnFileDialogCsv.TabIndex = 2;
            this.btnFileDialogCsv.Text = "...";
            this.btnFileDialogCsv.UseVisualStyleBackColor = true;
            this.btnFileDialogCsv.Click += new System.EventHandler(this.btnFileDialogCsv_Click);
            // 
            // btnCsvProcessStart
            // 
            this.btnCsvProcessStart.Location = new System.Drawing.Point(1268, 25);
            this.btnCsvProcessStart.Name = "btnCsvProcessStart";
            this.btnCsvProcessStart.Size = new System.Drawing.Size(75, 23);
            this.btnCsvProcessStart.TabIndex = 3;
            this.btnCsvProcessStart.Text = "Start";
            this.btnCsvProcessStart.UseVisualStyleBackColor = true;
            this.btnCsvProcessStart.Click += new System.EventHandler(this.btnCsvProcessStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbValues1
            // 
            this.tbValues1.Location = new System.Drawing.Point(127, 170);
            this.tbValues1.Multiline = true;
            this.tbValues1.Name = "tbValues1";
            this.tbValues1.ReadOnly = true;
            this.tbValues1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbValues1.Size = new System.Drawing.Size(1056, 78);
            this.tbValues1.TabIndex = 4;
            // 
            // tbValues2
            // 
            this.tbValues2.Location = new System.Drawing.Point(127, 271);
            this.tbValues2.Multiline = true;
            this.tbValues2.Name = "tbValues2";
            this.tbValues2.ReadOnly = true;
            this.tbValues2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbValues2.Size = new System.Drawing.Size(1056, 78);
            this.tbValues2.TabIndex = 4;
            // 
            // tbFieldHeaders
            // 
            this.tbFieldHeaders.Location = new System.Drawing.Point(127, 71);
            this.tbFieldHeaders.Multiline = true;
            this.tbFieldHeaders.Name = "tbFieldHeaders";
            this.tbFieldHeaders.ReadOnly = true;
            this.tbFieldHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFieldHeaders.Size = new System.Drawing.Size(1056, 78);
            this.tbFieldHeaders.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1268, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Billing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbValues2);
            this.Controls.Add(this.tbFieldHeaders);
            this.Controls.Add(this.tbValues1);
            this.Controls.Add(this.btnCsvProcessStart);
            this.Controls.Add(this.btnFileDialogCsv);
            this.Controls.Add(this.lblPathToCsv);
            this.Controls.Add(this.tbPathToCsv);
            this.Name = "FrmMain";
            this.Text = "SWIGINO Billing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathToCsv;
        private System.Windows.Forms.TextBox tbPathToCsv;
        private System.Windows.Forms.OpenFileDialog dlgOpenCsv;
        private System.Windows.Forms.Button btnFileDialogCsv;
        private System.Windows.Forms.Button btnCsvProcessStart;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbValues1;
        private System.Windows.Forms.TextBox tbValues2;
        private System.Windows.Forms.TextBox tbFieldHeaders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

