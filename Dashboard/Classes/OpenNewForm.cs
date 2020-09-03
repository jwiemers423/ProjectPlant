using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormUI
{
    public class OpenNewForm
    {
        public static void mainToEditForm(MainForm mainForm, PlantInformationEditForm plantEditForm)
        {
            // Closes current MainForm form and opens PlantInformationEditForm               
            mainForm.Hide();
            plantEditForm.ShowDialog();
            mainForm.Close();
            MainForm.plantSelected = false;
        }
        public static void mainToDisplayForm(MainForm mainForm, PlantInformationDisplayForm plantInfoDisplayForm)
        {
            // Closes current MainForm and opens PlantInformationDisplayForm               
            mainForm.Hide();
            plantInfoDisplayForm.ShowDialog();
            mainForm.Close();
        }
        public static void displayToMain(PlantInformationDisplayForm plantInfoDisplayForm, MainForm mainForm)
        {
            // Closes current PlantInformationDisplayForm and opens new MainForm
            plantInfoDisplayForm.Hide();
            mainForm.ShowDialog();
            plantInfoDisplayForm.Close();
            MainForm.plantSelected = false;
        }
        public static void displayToEdit(PlantInformationDisplayForm plantInfoDisplayForm, PlantInformationEditForm plantEditForm)
        {
            // Closes current PlantInformationDisplayForm and opens new PlantInformationEditForm
            plantInfoDisplayForm.Hide();
            plantEditForm.ShowDialog();
            plantInfoDisplayForm.Close();
        }
        public static void editToMain(PlantInformationEditForm plantEditForm, MainForm mainForm)
        {
            // Closes current PlantInformationEditForm and opens new MainForm
            plantEditForm.Hide();
            mainForm.ShowDialog();
            plantEditForm.Close();
        }
        public static void editToDisplay(PlantInformationEditForm plantEditForm, PlantInformationDisplayForm plantInformationDisplayForm)
        {
            // Copies data from edit textboxes to display on display textboxes
            plantInformationDisplayForm.commonNameTextBox.Text = plantEditForm.commonNameTextBox.Text;
            plantInformationDisplayForm.botanicalNameTextBox.Text = plantEditForm.botanicalNameTextBox.Text;
            plantInformationDisplayForm.waterRequirementTextBox.Text = plantEditForm.waterRequirementTextBox.Text;
            plantInformationDisplayForm.lightRequirementTextBox.Text = plantEditForm.lightRequirementTextBox.Text;
            plantInformationDisplayForm.fertilizerRequirementTextBox.Text = plantEditForm.fertilizerRequirementTextBox.Text;
            plantInformationDisplayForm.moreInfoTextBox.Text = plantEditForm.moreInfoTextBox.Text;
            plantInformationDisplayForm.plantPictureBox.Image = plantEditForm.plantPictureBox.Image;
            
            // Closes current PlantInformationEditForm and opens new PlantInformationDisplayForm
            plantEditForm.Hide();
            plantInformationDisplayForm.ShowDialog();
            plantEditForm.Close();
        }
    }
}