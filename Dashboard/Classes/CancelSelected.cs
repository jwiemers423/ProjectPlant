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
        public static void cancelSelected( PlantInformationEditForm plantInformationEditForm)
        {
            //Clears data so a clean form will be opened
            MainForm.plantSelected = false;
            PlantInformationEditForm.plantId = 0;
            plantInformationEditForm.commonNameTextBox.Text = plantInformationEditForm.botanicalNameTextBox.Text = plantInformationEditForm.waterRequirementTextBox.Text =
                    plantInformationEditForm.lightRequirementTextBox.Text = plantInformationEditForm.fertilizerRequirementTextBox.Text = plantInformationEditForm.moreInfoTextBox.Text =  "";
            plantInformationEditForm.plantPictureBox.Image = null;
        }
    }
}
