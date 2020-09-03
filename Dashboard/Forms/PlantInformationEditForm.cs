using System;
using System.IO;
using System.Windows.Forms;

namespace FormUI
{
    public partial class PlantInformationEditForm : Form
    {
        public static int plantId = 0;
        public PlantInformationEditForm()
        {            
            InitializeComponent(); 
        }

        //Events
        private void addPlantButton_Click(object sender, EventArgs e)
        {
        byte[] img = null;
        DataAccess db = new DataAccess();
            
            //Stops user from inputing too many characters
            if (commonNameTextBox.Text.Length > 100 || botanicalNameTextBox.Text.Length > 100 || waterRequirementTextBox.Text.Length > 100 ||
                fertilizerRequirementTextBox.Text.Length > 100 || lightRequirementTextBox.Text.Length > 100 || moreInfoTextBox.Text.Length > 2000)
            {
                MessageBox.Show("Input too long");
                return;
            }
            
            //Stops user form inputing blank textboxes
            if (commonNameTextBox.Text.Length == 0 || botanicalNameTextBox.Text.Length == 0 || waterRequirementTextBox.Text.Length == 0 ||
                fertilizerRequirementTextBox.Text.Length == 0 || lightRequirementTextBox.Text.Length == 0 || moreInfoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please ensure all fields are filled out");
                return;
            }

            //Decides if program should update an existing plant or save a new one          
            if (MainForm.plantSelected == true)
            {
                img = ImageConverter.imageToByteArray(plantPictureBox.Image);
                MessageBox.Show("Edit saved");
                db.UpdatePlant(plantId, commonNameTextBox.Text, botanicalNameTextBox.Text,
                lightRequirementTextBox.Text, waterRequirementTextBox.Text,
                fertilizerRequirementTextBox.Text, moreInfoTextBox.Text, img);
                PlantInformationDisplayForm plantInformationDisplayForm = new PlantInformationDisplayForm();
                OpenNewForm.editToDisplay(this, plantInformationDisplayForm);
            }

            else
            {
                //Converts selected plant location and converts to image.
                try
                {
                    PlantInformationDisplayForm plantInformationDisplayForm = new PlantInformationDisplayForm();
                    FileStream fs = new FileStream(plantPictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    MessageBox.Show("Plant saved successfully");
                    db.SavePlant(commonNameTextBox.Text, botanicalNameTextBox.Text,
                    lightRequirementTextBox.Text, waterRequirementTextBox.Text,
                    fertilizerRequirementTextBox.Text, moreInfoTextBox.Text, img);
                    OpenNewForm.editToDisplay(this, plantInformationDisplayForm);
                }
                catch
                {
                    MessageBox.Show("Please select a photo");                    
                }
            }            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Deletes currently selected plant form list/datagridview
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
                DataAccess db = new DataAccess();
                db.DeletePlant(plantId);
                MessageBox.Show("Plant Deleted Successfully");
                
                deleteButton.Enabled = false;
                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
                MainForm.plantSelected = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
            var mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
            MainForm.plantSelected = false;
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            //Opens file explorer box so user can select an image
            DataAccess db = new DataAccess();
            plantPictureBox.ImageLocation = db.BrowsePhoto();            
        }

        //KeyPress Event for all textboxes
        private void KeyPressDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                PlantInformationDisplayForm plantInformationDisplayForm = new PlantInformationDisplayForm();
                OpenNewForm.editToDisplay(this, plantInformationDisplayForm);
            }
        }       
    }
}
