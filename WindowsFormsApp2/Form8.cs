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
    public partial class Form8 : Form
    {
        FileStream fs;
        public Form8()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book bk = new Book();
                bk.Id = Convert.ToInt32(txtBookId.Text);
                bk.Name = txtBookName.Text;
                bk.AuthorName = txtAuthorName.Text;
                bk.Price = Convert.ToInt32(txtBookPrice.Text);
                fs = new FileStream(@"D:\TestFolder1\Book", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, bk);
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
                Book bk = new Book();
                fs = new FileStream(@"D:\TestFolder1\Book", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                bk = (Book)binary.Deserialize(fs);
                txtBookId.Text = bk.Id.ToString();
                txtBookName.Text =bk.Name;
                txtAuthorName.Text = bk.AuthorName;
                txtBookPrice.Text = bk.Price.ToString();
                

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

                Book bk = new Book();
                bk.Id = Convert.ToInt32(txtBookId.Text);
                bk.Name = txtBookName.Text;
                bk.AuthorName = txtAuthorName.Text;
                bk.Price = Convert.ToInt32(txtBookPrice.Text);
                fs = new FileStream(@"D:\TestFolder1\BookXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, bk);
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
                Book bk = new Book();
                fs = new FileStream(@"D:\TestFolder1\BookXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                bk = (Book)xml.Deserialize(fs);
                txtBookId.Text = bk.Id.ToString();
                txtBookName.Text = bk.Name;
                txtAuthorName.Text = bk.AuthorName;
                txtBookPrice.Text = bk.Price.ToString();


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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book bk = new Book();
                bk.Id = Convert.ToInt32(txtBookId.Text);
                bk.Name = txtBookName.Text;
                bk.AuthorName = txtAuthorName.Text;
                bk.Price = Convert.ToInt32(txtBookPrice.Text);
                fs = new FileStream(@"D:\TestFolder1\BookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter binary = new SoapFormatter();
                binary.Serialize(fs, bk);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book bk = new Book();
                fs = new FileStream(@"D:\TestFolder1\BookSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter binary = new SoapFormatter();
                bk = (Book)binary.Deserialize(fs);
                txtBookId.Text = bk.Id.ToString();
                txtBookName.Text = bk.Name;
                txtAuthorName.Text = bk.AuthorName;
                txtBookPrice.Text = bk.Price.ToString();

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
                Book bk = new Book();
                bk.Id = Convert.ToInt32(txtBookId.Text);
                bk.Name = txtBookName.Text;
                bk.AuthorName = txtAuthorName.Text;
                bk.Price = Convert.ToInt32(txtBookPrice.Text);
                fs = new FileStream(@"D:\TestFolder1\BookJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, bk);
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
                Book bk = new Book();
                fs = new FileStream(@"D:\TestFolder1\BookJson", FileMode.Open, FileAccess.Read);
                bk= JsonSerializer.Deserialize<Book>(fs);
                txtBookId.Text = bk.Id.ToString();
                txtBookName.Text = bk.Name;
                txtAuthorName.Text = bk.AuthorName;
                txtBookPrice.Text = bk.Price.ToString();
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
    
    

