using BeautySaloonForStudents.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonForStudents
{
    public partial class AddForm : Form
    {
        private string _imagePath;
        public AddForm()
        {
            InitializeComponent();
            _imagePath = @"Products\null.png";
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            costTextBox.Text = "";
            isActiveCheckBox.Checked = false;
            descriptionTextBox.Text = "";

            imagePictureBox.Image = Image.FromFile(_imagePath);

            manufacturerIDComboBox.DataSource = Getter.db.Manufacturer.Select(m => m.Name).ToList();
            manufacturerIDComboBox.SelectedIndex = 0;
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

        private void addButton_Click(object sender, EventArgs e)
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

            Product product = new Product();

            product.Title = titleTextBox.Text;
            product.Description = descriptionTextBox.Text;
            product.ManufacturerID = manufacturerIDComboBox.SelectedIndex + 1;
            product.MainImagePath = _imagePath;
            product.IsActive = isActiveCheckBox.Checked;
            product.Cost = cost;

            Getter.db.Product.Add(product);

            Getter.db.SaveChanges();

            MessageBox.Show("Товар успешно добавлен!");
            Getter.updateProducts();
            this.Close();
        }
    }
}
