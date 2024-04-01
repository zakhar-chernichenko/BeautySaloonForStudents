namespace BeautySaloonForStudents.Views
{
    partial class ChangeCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCostForm));
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.changeCostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(15, 15);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(423, 40);
            this.costTextBox.TabIndex = 0;
            // 
            // changeCostButton
            // 
            this.changeCostButton.Location = new System.Drawing.Point(155, 78);
            this.changeCostButton.Margin = new System.Windows.Forms.Padding(6);
            this.changeCostButton.Name = "changeCostButton";
            this.changeCostButton.Size = new System.Drawing.Size(169, 47);
            this.changeCostButton.TabIndex = 0;
            this.changeCostButton.Text = "Изменить";
            this.changeCostButton.UseVisualStyleBackColor = true;
            this.changeCostButton.Click += new System.EventHandler(this.changeCostButton_Click);
            // 
            // ChangeCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 151);
            this.Controls.Add(this.changeCostButton);
            this.Controls.Add(this.costTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangeCostForm";
            this.Text = "Изменить цену";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button changeCostButton;
    }
}