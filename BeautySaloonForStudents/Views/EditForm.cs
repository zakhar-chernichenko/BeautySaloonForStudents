using BeautySaloonForStudents.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonForStudents
{
    public partial class EditForm : Form
    {
        private Product _product;
        private string _imagePath;

        public EditForm(Product product)
        {
            InitializeComponent();
            _product = product;
            _imagePath = _product.MainImagePath;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            idValueLabel.Text = _product.ID.ToString();
            titleTextBox.Text = _product.Title;
            costTextBox.Text = _product.Cost.ToString();
            isActiveCheckBox.Checked = _product.IsActive;
            descriptionTextBox.Text = _product.Description;

            imagePictureBox.Image = Image.FromFile(string.IsNullOrEmpty(_imagePath) ? @"Products\null.png" : _imagePath);

            manufacturerIDComboBox.DataSource = Getter.db.Manufacturer.Select(m => m.Name).ToList();
            manufacturerIDComboBox.SelectedIndex = (_product.ManufacturerID ?? 1) - 1;
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imagePath = ofd.FileName;
                imagePictureBox.Image = Image.FromFile(_imagePath);
            }

            ofd.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Getter.db.Product.Remove(_product);
            Getter.db.SaveChanges();

            MessageBox.Show($"Товар {_product.Title} успешно удален!");
            Getter.updateProducts();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show("Поля заполнены неверно!");
                return;
            }

            try 
            { 
                Convert.ToDecimal(costTextBox.Text); 
            }
            catch
            {
                MessageBox.Show("Цена указана неверно!");
                return;
            }

            var cost = Convert.ToDecimal(costTextBox.Text);
            if (cost < 0)
            {
                MessageBox.Show("Цена указана неверно!");
                return;
            }

            _product.Title = titleTextBox.Text;
            _product.Description = descriptionTextBox.Text;
            _product.ManufacturerID = manufacturerIDComboBox.SelectedIndex + 1;
            _product.MainImagePath = _imagePath;
            _product.IsActive = isActiveCheckBox.Checked;
            _product.Cost = cost;

            Getter.db.SaveChanges();
            MessageBox.Show("Данные успешно изменены!");
            Getter.updateProducts();
            this.Close();
        }
    }
}
