namespace RateApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOrgCity = new System.Windows.Forms.TextBox();
            this.txtOrgState = new System.Windows.Forms.TextBox();
            this.txtOrgZip = new System.Windows.Forms.TextBox();
            this.txtDestZip = new System.Windows.Forms.TextBox();
            this.txtDestState = new System.Windows.Forms.TextBox();
            this.txtDestCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCsrId = new System.Windows.Forms.TextBox();
            this.txtSalesPersonId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdExport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblNumLoads = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPrimary = new System.Windows.Forms.CheckBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdSearchWeek = new System.Windows.Forms.Button();
            this.cmdSearchMonth = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPricingRateId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(12, 52);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(823, 32);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(79, 44);
            this.cmdSearch.TabIndex = 8;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(823, 91);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(79, 25);
            this.cmdReset.TabIndex = 9;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUpdate.Location = new System.Drawing.Point(1267, 12);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(113, 31);
            this.cmdUpdate.TabIndex = 20;
            this.cmdUpdate.Text = "Update Awards";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Visible = false;
            this.cmdUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridResults.Location = new System.Drawing.Point(12, 208);
            this.dataGridResults.MultiSelect = false;
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(1368, 303);
            this.dataGridResults.TabIndex = 50;
            this.dataGridResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResults_CellClick);
            this.dataGridResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridResults_CellFormatting);
            this.dataGridResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridResults_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // txtOrgCity
            // 
            this.txtOrgCity.Location = new System.Drawing.Point(87, 34);
            this.txtOrgCity.Name = "txtOrgCity";
            this.txtOrgCity.Size = new System.Drawing.Size(100, 20);
            this.txtOrgCity.TabIndex = 12;
            this.txtOrgCity.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtOrgState
            // 
            this.txtOrgState.Location = new System.Drawing.Point(199, 34);
            this.txtOrgState.Name = "txtOrgState";
            this.txtOrgState.Size = new System.Drawing.Size(100, 20);
            this.txtOrgState.TabIndex = 13;
            this.txtOrgState.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtOrgZip
            // 
            this.txtOrgZip.Location = new System.Drawing.Point(312, 34);
            this.txtOrgZip.Name = "txtOrgZip";
            this.txtOrgZip.Size = new System.Drawing.Size(100, 20);
            this.txtOrgZip.TabIndex = 14;
            this.txtOrgZip.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // txtDestZip
            // 
            this.txtDestZip.Location = new System.Drawing.Point(767, 34);
            this.txtDestZip.Name = "txtDestZip";
            this.txtDestZip.Size = new System.Drawing.Size(100, 20);
            this.txtDestZip.TabIndex = 17;
            this.txtDestZip.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // txtDestState
            // 
            this.txtDestState.Location = new System.Drawing.Point(654, 34);
            this.txtDestState.Name = "txtDestState";
            this.txtDestState.Size = new System.Drawing.Size(100, 20);
            this.txtDestState.TabIndex = 16;
            this.txtDestState.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // txtDestCity
            // 
            this.txtDestCity.Location = new System.Drawing.Point(542, 34);
            this.txtDestCity.Name = "txtDestCity";
            this.txtDestCity.Size = new System.Drawing.Size(100, 20);
            this.txtDestCity.TabIndex = 15;
            this.txtDestCity.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Origin Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Zip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Destination Filter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "City";
            // 
            // txtCsrId
            // 
            this.txtCsrId.Location = new System.Drawing.Point(141, 52);
            this.txtCsrId.Name = "txtCsrId";
            this.txtCsrId.Size = new System.Drawing.Size(100, 20);
            this.txtCsrId.TabIndex = 2;
            // 
            // txtSalesPersonId
            // 
            this.txtSalesPersonId.Location = new System.Drawing.Point(267, 52);
            this.txtSalesPersonId.Name = "txtSalesPersonId";
            this.txtSalesPersonId.Size = new System.Drawing.Size(100, 20);
            this.txtSalesPersonId.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "CSR ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "SalesPerson ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 517);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1368, 262);
            this.dataGridView1.TabIndex = 50;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(403, 49);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(183, 20);
            this.dateFrom.TabIndex = 4;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(606, 49);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(188, 20);
            this.dateTo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Date From";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(603, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Date To";
            // 
            // cmdExport
            // 
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExport.Location = new System.Drawing.Point(1287, 173);
            this.cmdExport.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(90, 25);
            this.cmdExport.TabIndex = 19;
            this.cmdExport.Text = "Export Results";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 787);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 24);
            this.label16.TabIndex = 52;
            this.label16.Text = "Number of Loads:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(555, 787);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 24);
            this.label17.TabIndex = 53;
            this.label17.Text = "Total Profit:";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(663, 787);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(0, 24);
            this.lblTotalProfit.TabIndex = 54;
            // 
            // lblNumLoads
            // 
            this.lblNumLoads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumLoads.AutoSize = true;
            this.lblNumLoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLoads.Location = new System.Drawing.Point(178, 787);
            this.lblNumLoads.Name = "lblNumLoads";
            this.lblNumLoads.Size = new System.Drawing.Size(0, 24);
            this.lblNumLoads.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOrgCity);
            this.panel1.Controls.Add(this.txtOrgState);
            this.panel1.Controls.Add(this.txtOrgZip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDestCity);
            this.panel1.Controls.Add(this.txtDestState);
            this.panel1.Controls.Add(this.txtDestZip);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 70);
            this.panel1.TabIndex = 56;
            // 
            // chkPrimary
            // 
            this.chkPrimary.AutoSize = true;
            this.chkPrimary.Checked = true;
            this.chkPrimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrimary.Location = new System.Drawing.Point(368, 95);
            this.chkPrimary.Name = "chkPrimary";
            this.chkPrimary.Size = new System.Drawing.Size(152, 17);
            this.chkPrimary.TabIndex = 7;
            this.chkPrimary.Text = "Show Only Primary Awards";
            this.chkPrimary.UseVisualStyleBackColor = true;
            // 
            // fbd
            // 
            this.fbd.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // cmdSearchWeek
            // 
            this.cmdSearchWeek.Location = new System.Drawing.Point(538, 90);
            this.cmdSearchWeek.Name = "cmdSearchWeek";
            this.cmdSearchWeek.Size = new System.Drawing.Size(125, 26);
            this.cmdSearchWeek.TabIndex = 10;
            this.cmdSearchWeek.Text = "Search Past Week";
            this.cmdSearchWeek.UseVisualStyleBackColor = true;
            this.cmdSearchWeek.Click += new System.EventHandler(this.cmdSearchWeek_Click);
            // 
            // cmdSearchMonth
            // 
            this.cmdSearchMonth.Location = new System.Drawing.Point(669, 90);
            this.cmdSearchMonth.Name = "cmdSearchMonth";
            this.cmdSearchMonth.Size = new System.Drawing.Size(125, 26);
            this.cmdSearchMonth.TabIndex = 11;
            this.cmdSearchMonth.Text = "Search Past Month";
            this.cmdSearchMonth.UseVisualStyleBackColor = true;
            this.cmdSearchMonth.Click += new System.EventHandler(this.cmdSearchMonth_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Visible = false;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtPricingRateId
            // 
            this.txtPricingRateId.Location = new System.Drawing.Point(12, 96);
            this.txtPricingRateId.Name = "txtPricingRateId";
            this.txtPricingRateId.Size = new System.Drawing.Size(100, 20);
            this.txtPricingRateId.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Pricing Rate ID";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdd.Location = new System.Drawing.Point(1267, 52);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(113, 31);
            this.cmdAdd.TabIndex = 61;
            this.cmdAdd.Text = "Add Award";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Visible = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 825);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtPricingRateId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmdSearchMonth);
            this.Controls.Add(this.cmdSearchWeek);
            this.Controls.Add(this.chkPrimary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumLoads);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSalesPersonId);
            this.Controls.Add(this.txtCsrId);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rate Helper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.TextBox txtOrgCity;
        private System.Windows.Forms.TextBox txtOrgState;
        private System.Windows.Forms.TextBox txtOrgZip;
        private System.Windows.Forms.TextBox txtDestZip;
        private System.Windows.Forms.TextBox txtDestState;
        private System.Windows.Forms.TextBox txtDestCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCsrId;
        private System.Windows.Forms.TextBox txtSalesPersonId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblNumLoads;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkPrimary;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button cmdSearchWeek;
        private System.Windows.Forms.Button cmdSearchMonth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPricingRateId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdAdd;
    }
}

