namespace EbayCrawler
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
            this.lvData = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUsed = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.numResults = new System.Windows.Forms.NumericUpDown();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.numMaxRange = new System.Windows.Forms.NumericUpDown();
            this.numMinRange = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboxCatagories = new System.Windows.Forms.ComboBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblItemResults = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinRange)).BeginInit();
            this.SuspendLayout();
            // 
            // lvData
            // 
            this.lvData.BackColor = System.Drawing.Color.Gray;
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colTitle,
            this.colPrice,
            this.colBids,
            this.colLink});
            this.lvData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.Location = new System.Drawing.Point(12, 173);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(849, 297);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 200;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            // 
            // colBids
            // 
            this.colBids.Text = "Bids";
            this.colBids.Width = 125;
            // 
            // colLink
            // 
            this.colLink.Text = "Link";
            this.colLink.Width = 334;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsed);
            this.groupBox1.Controls.Add(this.rbNew);
            this.groupBox1.Controls.Add(this.lblCondition);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.numResults);
            this.groupBox1.Controls.Add(this.lblResults);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.numMaxRange);
            this.groupBox1.Controls.Add(this.numMinRange);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.cboxCatagories);
            this.groupBox1.Controls.Add(this.lblCatagory);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Details";
            // 
            // rbUsed
            // 
            this.rbUsed.AutoSize = true;
            this.rbUsed.Location = new System.Drawing.Point(313, 116);
            this.rbUsed.Name = "rbUsed";
            this.rbUsed.Size = new System.Drawing.Size(54, 17);
            this.rbUsed.TabIndex = 15;
            this.rbUsed.TabStop = true;
            this.rbUsed.Text = "Used";
            this.rbUsed.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(252, 116);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(50, 17);
            this.rbNew.TabIndex = 14;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(171, 118);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(72, 13);
            this.lblCondition.TabIndex = 13;
            this.lblCondition.Text = "Condition  :";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(446, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(446, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(446, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // numResults
            // 
            this.numResults.Location = new System.Drawing.Point(102, 114);
            this.numResults.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numResults.Name = "numResults";
            this.numResults.Size = new System.Drawing.Size(62, 20);
            this.numResults.TabIndex = 9;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(36, 117);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(61, 13);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "Results  :";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(171, 90);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To ";
            // 
            // numMaxRange
            // 
            this.numMaxRange.DecimalPlaces = 2;
            this.numMaxRange.Location = new System.Drawing.Point(200, 87);
            this.numMaxRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxRange.Name = "numMaxRange";
            this.numMaxRange.Size = new System.Drawing.Size(61, 20);
            this.numMaxRange.TabIndex = 6;
            // 
            // numMinRange
            // 
            this.numMinRange.DecimalPlaces = 2;
            this.numMinRange.Location = new System.Drawing.Point(103, 87);
            this.numMinRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinRange.Name = "numMinRange";
            this.numMinRange.Size = new System.Drawing.Size(61, 20);
            this.numMinRange.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 89);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price Range  :";
            // 
            // cboxCatagories
            // 
            this.cboxCatagories.FormattingEnabled = true;
            this.cboxCatagories.Items.AddRange(new object[] {
            "All Catagories",
            "Antiques",
            "Art",
            "Baby",
            "Books",
            "Business & Industrial",
            "Cameras & Photo",
            "Cell Phones & Accessories",
            "Clothing, Shoes & Accessories",
            "Coins & Paper Money",
            "Collectibles"});
            this.cboxCatagories.Location = new System.Drawing.Point(102, 59);
            this.cboxCatagories.Name = "cboxCatagories";
            this.cboxCatagories.Size = new System.Drawing.Size(240, 21);
            this.cboxCatagories.TabIndex = 3;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(32, 63);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(65, 13);
            this.lblCatagory.TabIndex = 2;
            this.lblCatagory.Text = "Catagory :";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(38, 35);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product :";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(102, 32);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(240, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(735, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count :";
            // 
            // lblItemResults
            // 
            this.lblItemResults.AutoSize = true;
            this.lblItemResults.Location = new System.Drawing.Point(581, 144);
            this.lblItemResults.Name = "lblItemResults";
            this.lblItemResults.Size = new System.Drawing.Size(13, 13);
            this.lblItemResults.TabIndex = 16;
            this.lblItemResults.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(874, 482);
            this.Controls.Add(this.lblItemResults);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebay Crawler Version 1.0.0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colBids;
        private System.Windows.Forms.ColumnHeader colLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown numMaxRange;
        private System.Windows.Forms.NumericUpDown numMinRange;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboxCatagories;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.RadioButton rbUsed;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblItemResults;
    }
}

