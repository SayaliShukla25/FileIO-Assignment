using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtProductId.Text);
                prod.Name = txtProductName.Text;
                prod.Price = Convert.ToInt32 (txtProductPrice.Text);
                prod.CategoryName= txtProdCategoryName.Text;
                fs = new FileStream(@"D:\TestFolder1\Prod", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder1\Prod", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod= (Product)binary.Deserialize(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text= prod.Name;
                txtProductPrice.Text = prod.Price.ToString();
                txtProdCategoryName.Text = prod.CategoryName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        { 
        try
            { 
            Product prod = new Product();
            prod.Id = Convert.ToInt32(txtProductId.Text);
            prod.Name = txtProductName.Text;
            prod.Price = Convert.ToInt32(txtProductPrice.Text);
            prod.CategoryName = txtProdCategoryName.Text;
            fs = new FileStream(@"D:\TestFolder1\ProdXml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            xml.Serialize(fs, prod);
            MessageBox.Show("Done");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder1\ProdXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text = prod.Name;
                txtProductPrice.Text = prod.Price.ToString();
                txtProdCategoryName.Text = prod.CategoryName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtProductId.Text);
                prod.Name = txtProductName.Text;
                prod.Price = Convert.ToInt32(txtProductPrice.Text);
                prod.CategoryName = txtProdCategoryName.Text;
                fs = new FileStream(@"D:\TestFolder1\ProdJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder1\ProdJson", FileMode.Open, FileAccess.Read);
                prod = JsonSerializer.Deserialize<Product>(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text = prod.Name;
                txtProductPrice.Text = prod.Price.ToString();
                txtProdCategoryName.Text = prod.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
    }

