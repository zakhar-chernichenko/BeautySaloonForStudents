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

namespace BeautySaloonForStudents.Views
{
    public partial class ChangeCostForm : Form
    {
        private List<Product> _products;
        public ChangeCostForm(List<Product> products)
        {
            InitializeComponent();
            _products = products;

            costTextBox.Text = (_products.Select(p => p.Cost).Sum() / _products.Count).ToString();
        }

        private void changeCostButton_Click(object sender, EventArgs e)
        {
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

            _products.ForEach(p =>
            {
                p.Cost = cost;
            });

            Getter.db.SaveChanges();
            MessageBox.Show("Цена на товары изменена!");

            Close();
        }
    }
}
