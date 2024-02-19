namespace SmartCarpark
{
    partial class wallet
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
            System.Windows.Forms.Label label1;
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnwallet = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carParkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carParkDataSet = new SmartCarpark.CarParkDataSet();
            this.transTableAdapter = new SmartCarpark.CarParkDataSetTableAdapters.TransTableAdapter();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 113);
            label1.TabIndex = 0;
            label1.Text = "m";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnprofile
            // 
            this.btnprofile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprofile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnprofile.BackgroundImage = global::SmartCarpark.Properties.Resources.profile;
            this.btnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprofile.FlatAppearance.BorderSize = 0;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.Location = new System.Drawing.Point(3, 116);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(155, 105);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnwallet
            // 
            this.btnwallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnwallet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnwallet.BackgroundImage = global::SmartCarpark.Properties.Resources.Wallet;
            this.btnwallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnwallet.FlatAppearance.BorderSize = 0;
            this.btnwallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwallet.ForeColor = System.Drawing.Color.White;
            this.btnwallet.Location = new System.Drawing.Point(3, 347);
            this.btnwallet.Name = "btnwallet";
            this.btnwallet.Size = new System.Drawing.Size(155, 97);
            this.btnwallet.TabIndex = 5;
            this.btnwallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnwallet.UseVisualStyleBackColor = true;
            this.btnwallet.Click += new System.EventHandler(this.btnwallet_Click);
            // 
            // btnhome
            // 
            this.btnhome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnhome.BackgroundImage = global::SmartCarpark.Properties.Resources.home_black;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Location = new System.Drawing.Point(3, 227);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(155, 114);
            this.btnhome.TabIndex = 1;
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnreport
            // 
            this.btnreport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnreport.BackgroundImage = global::SmartCarpark.Properties.Resources.Error;
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(3, 562);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(155, 112);
            this.btnreport.TabIndex = 4;
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndashboard.BackgroundImage = global::SmartCarpark.Properties.Resources.Dashboard;
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(3, 450);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(155, 106);
            this.btndashboard.TabIndex = 2;
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnprofile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnwallet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnhome, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnreport, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btndashboard, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.91304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.08696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(161, 677);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(164, 347);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(15, 97);
            this.panelLeft.TabIndex = 14;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(1153, 9);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 34);
            this.lblBalance.TabIndex = 22;
            this.lblBalance.Text = "Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBalance.Click += new System.EventHandler(this.Name_Click);
            // 
            // Balance
            // 
            this.Balance.AutoEllipsis = true;
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(1171, 43);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(86, 34);
            this.Balance.TabIndex = 23;
            this.Balance.Text = "$5.90";
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitDateDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.entryTImeDataGridViewTextBoxColumn,
            this.exitTImeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(161, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 677);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            this.visitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryTImeDataGridViewTextBoxColumn
            // 
            this.entryTImeDataGridViewTextBoxColumn.DataPropertyName = "EntryTIme";
            this.entryTImeDataGridViewTextBoxColumn.HeaderText = "EntryTIme";
            this.entryTImeDataGridViewTextBoxColumn.Name = "entryTImeDataGridViewTextBoxColumn";
            this.entryTImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exitTImeDataGridViewTextBoxColumn
            // 
            this.exitTImeDataGridViewTextBoxColumn.DataPropertyName = "ExitTIme";
            this.exitTImeDataGridViewTextBoxColumn.HeaderText = "ExitTIme";
            this.exitTImeDataGridViewTextBoxColumn.Name = "exitTImeDataGridViewTextBoxColumn";
            this.exitTImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transBindingSource
            // 
            this.transBindingSource.DataMember = "Trans";
            this.transBindingSource.DataSource = this.carParkDataSetBindingSource;
            // 
            // carParkDataSetBindingSource
            // 
            this.carParkDataSetBindingSource.DataSource = this.carParkDataSet;
            this.carParkDataSetBindingSource.Position = 0;
            // 
            // carParkDataSet
            // 
            this.carParkDataSet.DataSetName = "CarParkDataSet";
            this.carParkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transTableAdapter
            // 
            this.transTableAdapter.ClearBeforeFill = true;
            // 
            // wallet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1301, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "wallet";
            this.Text = "wallet";
            this.Load += new System.EventHandler(this.wallet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnwallet;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carParkDataSetBindingSource;
        private CarParkDataSet carParkDataSet;
        private System.Windows.Forms.BindingSource transBindingSource;
        private CarParkDataSetTableAdapters.TransTableAdapter transTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTImeDataGridViewTextBoxColumn;
    }
}