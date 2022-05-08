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
    public partial class Form9 : Form
    {
        FileStream fs;
        public Form9()
        {
            InitializeComponent();
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                
                int BatchId = Convert.ToInt32(txtBatchId.Text);
                string BatchName = txtBatchName.Text;
                string StartDate = txtEndDate.Text;
                string EndDate = txtEndDate.Text;
                String Location = txtLocation.Text;
                String TrainerName = txtTrainerName.Text;
                fs = new FileStream(@"D:\TestFolder\Batch.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(BatchId);
                bw.Write(BatchName);
                bw.Write(StartDate);
                bw.Write(EndDate);
                bw.Write(Location);
                bw.Write(TrainerName);
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

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\Batch.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtBatchId.Text = br.ReadInt32().ToString();
                txtBatchName.Text = br.ReadString();
                txtStartDate.Text = br.ReadString();
                txtEndDate.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                txtTrainerName.Text = br.ReadString();

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
