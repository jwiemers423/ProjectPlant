using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class CancelSelected
    {
        public static void cancelSelected( Button addNewButton, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4,
            TextBox textBox5, TextBox textBox6, PictureBox pictureBox)
        {
            //Clears data so a clean form will be opened
            MainForm.plantSelected = false;
            addNewButton.Text = "Add New";
            PlantInformationEditForm.plantId = 0;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
            pictureBox.Image = null;
        }
    }
}
