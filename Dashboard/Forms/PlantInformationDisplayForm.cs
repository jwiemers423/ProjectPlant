using System;
using System.Windows.Forms;

namespace FormUI
{
    public partial class PlantInformationDisplayForm : Form
    {
        public PlantInformationDisplayForm()
        {
            InitializeComponent();
        }
        
        //Events
        private void editPlantButton_Click(object sender, EventArgs e)
        {
            PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
            EditPlant.editPlant(plantInfoEditForm, this);
            OpenNewForm.displayToEdit(this, plantInfoEditForm);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            OpenNewForm.displayToMain(this, mainForm);
        }

        private void KeyPressDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                MainForm mainForm = new MainForm();
                OpenNewForm.displayToMain(this, mainForm);
            }
        }
    }
}
