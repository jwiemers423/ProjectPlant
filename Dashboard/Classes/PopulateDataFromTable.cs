using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class PopulateDataFromTable
    {
        public static void populateDataFromTable(DataGridView dataGridView, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4,
            TextBox textBox5, TextBox textBox6, PictureBox pictureBox)
        {
            //Selects plant and assigns plantID/textboxes/image from SQL table
            MainForm.plantSelected = true;
            PlantInformationEditForm.plantId = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            pictureBox.Image = byteArrayToImage((byte[])dataGridView.CurrentRow.Cells[7].Value);
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
