using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailId_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"FullName={txtFullName.Text},\nEmailId={txtEmaiId.Text},\nContactNumber={txtContactNumber.Text},\nAddress={txtAddress.Text}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmaiId.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
        }
    }
}
