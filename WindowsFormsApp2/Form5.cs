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

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNumber = Convert.ToInt32(txtRollNumber.Text);
                string Name = txtName.Text;
                float Percentage =Convert.ToSingle (txtPercentage.Text);
                String Stream = txtStream.Text;
                String City = txtCity.Text;
                fs=new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(RollNumber);
                bw.Write(Name);
                bw.Write(Percentage);
                bw.Write(Stream);
                bw.Write(City);
                bw.Close();
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollNumber.Text = br.ReadInt32().ToString() ;
                txtName.Text = br.ReadString();
                txtPercentage.Text = br.ReadSingle().ToString();
                txtStream.Text = br.ReadString() ;
                txtCity.Text= br.ReadString();

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
