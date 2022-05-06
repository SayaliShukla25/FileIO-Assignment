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
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
                string EmployeeName = txtEmployeeName.Text;
                String Designation = (txtDesignation.Text);
                Double Salary = Convert.ToInt64(txtSalary.Text);
                String Department = txtDepartment.Text;
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(EmployeeId);
                bw.Write(EmployeeName);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Department);
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
               txtEmployeeId.Text= br.ReadInt32().ToString();
               txtEmployeeName.Text= br.ReadString();
               txtDesignation.Text= br.ReadString();
               txtSalary.Text = br.ReadInt64().ToString();
               txtDepartment.Text= br.ReadString();

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
    

