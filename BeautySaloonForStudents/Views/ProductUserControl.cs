using BeautySaloonForStudents.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonForStudents
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(Product product, bool isCostChange)
        {
            InitializeComponent();

            // Elemets set
            imagePictureBox.Image = Image.FromFile(string.IsNullOrEmpty(product.MainImagePath) ? @"Products\null.png" : product.MainImagePath);

            titleLabel.Text = product.Title;
            priceLabel.Text = $"{product.Cost:f2}₽";
            isActiveLabel.Text = "";
            isChangeCost.Checked = isCostChange;

            if (!product.IsActive)
            {
                this.BackColor = Color.FromArgb(225, 228, 255);
                isActiveLabel.Text = "Не активен!";
            }

            // TODO: Edit maybe
            foreach (Control item in Controls)
            {
                if (item is Label || item is PictureBox)
                    item.Click += (sender, e) => new EditForm(product).ShowDialog();
            }

            // Events
            Click += (s, e) => new EditForm(product).ShowDialog();
            isChangeCost.CheckedChanged += (s, e) => Getter.updateCostProducts(product);
        }
    }
}
