using BeautySaloonForStudents.ModelEF;
using BeautySaloonForStudents.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonForStudents
{
    public partial class MainForm : Form
    {
        private readonly int _countProductsOnPage = 20;
        private int _currentPage = 1;
        private List<Product> _productsChangeCost;

        public MainForm()
        {
            InitializeComponent();
            _productsChangeCost = new List<Product>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var manufacturer = Getter.db.Manufacturer.Select(m => m.Name).ToList();
            manufacturer.Insert(0, "Все производители");
            filterComboBox.DataSource = manufacturer;
            
            sortComboBox.SelectedIndex = 0;

            PrepareData();
        }

        public void UpdateProductCostList(Product product)
        {
            if (_productsChangeCost.Contains(product)) _productsChangeCost.Remove(product);
            else _productsChangeCost.Add(product);

            if (_productsChangeCost.Count > 0) changeCostButton.Visible = true;
            else changeCostButton.Visible = false;
        }

        public void PrepareData()
        {
            // Get Data
            var products = Getter.db.Product.ToList();
            var productsCount = products.Count;

            // Filter Data
            if (filterComboBox.SelectedIndex != 0)
                products = products.Where(p => p.ManufacturerID == filterComboBox.SelectedIndex).ToList();

            // Search Data
            var searchString = searchTextBox.Text.Trim().ToLower();

            products = products
                .Where(p => p.Title.ToLower().Contains(searchString) ||
                 p.Description.ToLower().Contains(searchString))
                .ToList();

            // Sort Data
            switch (sortComboBox.SelectedIndex)
            {
                case 1:
                    products = products
                        .OrderBy(p => p.Title)
                        .OrderBy(p => p.Cost).ToList();
                    break;
                case 2:
                    products = products
                        .OrderByDescending(p => p.Title)
                        .OrderByDescending(p => p.Cost).ToList();
                    break;
            }

            // Fill Counter
            productCountLabel.Text = $"{products.Count}/{productsCount}";

            // For Pages
            var countPages = products.Count % _countProductsOnPage == 0 ? 
                products.Count / _countProductsOnPage :
                products.Count / _countProductsOnPage + 1;

            if (_currentPage < 1) _currentPage = 1;
            else if (_currentPage > countPages) _currentPage = countPages;

            products = products
                .Skip((_currentPage - 1) * _countProductsOnPage)
                .Take(_countProductsOnPage).ToList();

            // Fill pagesInfoLabel
            var pagesInfo = new List<string>();
            if (countPages > 0)
            {
                for (int i = 1; i <= countPages; i++)
                {
                    if (i == _currentPage) pagesInfo.Add($"({i})");
                    else pagesInfo.Add(i.ToString());
                }
            }
            else pagesInfo.Add("-");

            pagesInfoLabel.Text = string.Join(" ", pagesInfo);

            // Show Data
            productsPanel.Controls.Clear();
            foreach (var product in products)
            {
                productsPanel.Controls.Add(new ProductUserControl(product, _productsChangeCost.Contains(product)));
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void prevLabel_Click(object sender, EventArgs e)
        {
            _currentPage--;
            PrepareData();
        }

        private void nextLabel_Click(object sender, EventArgs e)
        {
            _currentPage++;
            PrepareData();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void changeCostButton_Click(object sender, EventArgs e)
        {
            new ChangeCostForm(_productsChangeCost).ShowDialog();
            _productsChangeCost.Clear();
            changeCostButton.Visible = false;
            PrepareData();
        }
    }
}
