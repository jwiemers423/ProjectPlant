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
        public static void populateDataFromTable(DataGridView dataGridView, PlantInformationDisplayForm plantInformationDisplayForm)
        {
            //Selects plant and assigns plantID/textboxes/image from SQL table
            MainForm.plantSelected = true;
            PlantInformationEditForm.plantId = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            plantInformationDisplayForm.commonNameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            plantInformationDisplayForm.botanicalNameTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            plantInformationDisplayForm.waterRequirementTextBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            plantInformationDisplayForm.lightRequirementTextBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            plantInformationDisplayForm.fertilizerRequirementTextBox.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            plantInformationDisplayForm.moreInfoTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            plantInformationDisplayForm.plantPictureBox.Image = ImageConverter.byteArrayToImage((byte[])dataGridView.CurrentRow.Cells[7].Value);
        }
    }
}
