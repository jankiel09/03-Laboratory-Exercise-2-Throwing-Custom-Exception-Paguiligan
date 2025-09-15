namespace _03LabExer2
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            richTxtDescription = new RichTextBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            cbCategory = new ComboBox();
            txtSellPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(470, 288);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(102, 23);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 317);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(560, 191);
            gridViewProductList.TabIndex = 1;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(327, 111);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(245, 168);
            richTxtDescription.TabIndex = 2;
            richTxtDescription.Text = "";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(98, 153);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(205, 23);
            dtPickerMfgDate.TabIndex = 3;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(98, 187);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(205, 23);
            dtPickerExpDate.TabIndex = 4;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(98, 119);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(205, 23);
            cbCategory.TabIndex = 5;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(98, 256);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(205, 23);
            txtSellPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(98, 222);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(205, 23);
            txtQuantity.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(99, 84);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(204, 23);
            txtProductName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 9;
            label1.Text = "Add Product";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 10;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 122);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 157);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 12;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 190);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 13;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 225);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 14;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 260);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 15;
            label7.Text = "Sell Price";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(327, 84);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 16;
            label8.Text = "Description";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 18, 60);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 27);
            panel1.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 6);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 1;
            label9.Text = "Inventory";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 18, 60);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(556, 0);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 520);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellPrice);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(richTxtDescription);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddProduct";
            Text = "Form1";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private DataGridView gridViewProductList;
        private RichTextBox richTxtDescription;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private ComboBox cbCategory;
        private TextBox txtSellPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Button button1;
        private Label label9;
    }
}
