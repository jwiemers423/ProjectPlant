using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class EditPlant
    {
        public static void editPlant(PlantInformationEditForm plantInformationEditForm, PlantInformationDisplayForm plantInformationDisplayForm )
        {
            //Transfers textbox data to editer form

            MainForm.plantSelected = true;
            plantInformationEditForm.deleteButton.Enabled = true;
            plantInformationEditForm.commonNameTextBox.Text = plantInformationDisplayForm.commonNameTextBox.Text;
            plantInformationEditForm.botanicalNameTextBox.Text = plantInformationDisplayForm.botanicalNameTextBox.Text;
            plantInformationEditForm.waterRequirementTextBox.Text = plantInformationDisplayForm.waterRequirementTextBox.Text;
            plantInformationEditForm.lightRequirementTextBox.Text = plantInformationDisplayForm.lightRequirementTextBox.Text;
            plantInformationEditForm.fertilizerRequirementTextBox.Text = plantInformationDisplayForm.fertilizerRequirementTextBox.Text;
            plantInformationEditForm.moreInfoTextBox.Text = plantInformationDisplayForm.moreInfoTextBox.Text;
            plantInformationEditForm.plantPictureBox.Image = plantInformationDisplayForm.plantPictureBox.Image;
        }
    }
}
