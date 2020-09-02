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
            // Closes current form and opens PlantInformationForm               
            mainForm.Hide();
            plantEditForm.ShowDialog();
            mainForm.Close();
            MainForm.plantSelected = false;
        }
        public static void mainToDisplayForm(MainForm mainForm, PlantInformationDisplayForm plantInfoDisplayForm)
        {
            // Closes current form and opens PlantInformationForm               
            mainForm.Hide();
            plantInfoDisplayForm.ShowDialog();
            mainForm.Close();
        }
    }
}