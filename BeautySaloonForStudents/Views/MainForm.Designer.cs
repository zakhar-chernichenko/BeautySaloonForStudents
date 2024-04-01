namespace BeautySaloonForStudents
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prevLabel = new System.Windows.Forms.Label();
            this.pagesInfoLabel = new System.Windows.Forms.Label();
            this.nextLabel = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.changeCostButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(13, 13);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(724, 32);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По возрастанию",
            "По убыванию"});
            this.sortComboBox.Location = new System.Drawing.Point(745, 13);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(258, 32);
            this.sortComboBox.TabIndex = 1;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(1011, 13);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(258, 32);
            this.filterComboBox.TabIndex = 2;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // productsPanel
            // 
            this.productsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Location = new System.Drawing.Point(13, 65);
            this.productsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1256, 511);
            this.productsPanel.TabIndex = 3;
            // 
            // productCountLabel
            // 
            this.productCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Location = new System.Drawing.Point(39, 605);
            this.productCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(64, 24);
            this.productCountLabel.TabIndex = 4;
            this.productCountLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.prevLabel);
            this.panel1.Controls.Add(this.pagesInfoLabel);
            this.panel1.Controls.Add(this.nextLabel);
            this.panel1.Location = new System.Drawing.Point(950, 605);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 43);
            this.panel1.TabIndex = 5;
            // 
            // prevLabel
            // 
            this.prevLabel.AutoSize = true;
            this.prevLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.prevLabel.Location = new System.Drawing.Point(193, 0);
            this.prevLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prevLabel.Name = "prevLabel";
            this.prevLabel.Size = new System.Drawing.Size(31, 24);
            this.prevLabel.TabIndex = 2;
            this.prevLabel.Text = "< ";
            this.prevLabel.Click += new System.EventHandler(this.prevLabel_Click);
            // 
            // pagesInfoLabel
            // 
            this.pagesInfoLabel.AutoSize = true;
            this.pagesInfoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagesInfoLabel.Location = new System.Drawing.Point(224, 0);
            this.pagesInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pagesInfoLabel.Name = "pagesInfoLabel";
            this.pagesInfoLabel.Size = new System.Drawing.Size(64, 24);
            this.pagesInfoLabel.TabIndex = 1;
            this.pagesInfoLabel.Text = "label3";
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextLabel.Location = new System.Drawing.Point(288, 0);
            this.nextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(31, 24);
            this.nextLabel.TabIndex = 0;
            this.nextLabel.Text = " >";
            this.nextLabel.Click += new System.EventHandler(this.nextLabel_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(139, 600);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(239, 34);
            this.addProduct.TabIndex = 6;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // changeCostButton
            // 
            this.changeCostButton.Location = new System.Drawing.Point(411, 600);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(239, 34);
            this.changeCostButton.TabIndex = 7;
            this.changeCostButton.Text = "Изменить цену на...";
            this.changeCostButton.UseVisualStyleBackColor = true;
            this.changeCostButton.Visible = false;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1282, 661);
            this.Controls.Add(this.changeCostButton);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productCountLabel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Салон красоты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.FlowLayoutPanel productsPanel;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prevLabel;
        private System.Windows.Forms.Label pagesInfoLabel;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button changeCostButton;
    }
}

