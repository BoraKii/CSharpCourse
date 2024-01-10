using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (ETradeContext context = new ETradeContext())
            {
                dgwProducts.DataSource = _productDal.GetAll();
            }
        }

        private void SearchProducts(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //var result = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList(); //Collection araması (ToLower  kodu ile büyük küçük aramaya duyarlı yapıyoruz.)
                var result = _productDal.GetByName(key); //veritabanında name ara
                dgwProducts.DataSource = result;
            }
        }

        private void GetById(int price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = _productDal.GetByUnitPrice(price);
                dgwProducts.DataSource = result;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        { 
            _productDal.GetById(1);
            GetById(3000);
            MessageBox.Show("Those with a unit price of 3000 are listed.");
        }
    }
}
