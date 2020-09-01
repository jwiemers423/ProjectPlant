using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace FormUI
{
    public partial class MainForm : Form
    {

        public PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
        public PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
        public static bool plantSelected = false;
              
        public MainForm()
        {
            InitializeComponent();
            UpdateBinding();
        }

        //Events

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Filters plants in sql by what is entered in the searchbar textbox
            UpdateBinding();
            if (plantSelected == true)
            {
                CancelSelected();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeletePlant();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }        
        
        private void addNewButton_Click(object sender, EventArgs e)
        {
            CancelSelected();
            OpenPlantInformationForm();
        }
               
        private void plantsDataGridView_Click(object sender, EventArgs e)
        {
            //Selects plant and assigns plant ID from SQL table         
            if (plantsDataGridView.CurrentRow.Index != -1)
            {
                plantSelected = true;
                deleteButton.Enabled = true;
                plantInfoEditForm.plantId = Convert.ToInt32(plantsDataGridView.CurrentRow.Cells[0].Value.ToString());                
            }   
        }        
        private void plantsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            PopulateDataFromTable();
        }

        private void plantsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Disables highlightbox from DataGridViewBox
            plantsDataGridView.ClearSelection();
        }

        private void plantsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //Deletes currently selected plant from list/datagridview using delete button from keyboard
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
                    DeletePlant();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            //Move into PlantInfoDisplay for selected plant
            if (e.KeyCode == Keys.Enter)
            {
                PopulateDataFromTable();
            }

            //Changes which plant is currently selected with arrow keys on keyboard
            if (e.KeyCode == Keys.Up)
            {
                MoveUp.moveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown.moveDown();
            }            
        }

        //Methods

        private void UpdateBinding()
        {
            List<Plant> plants = new List<Plant>();
            DataAccess db = new DataAccess();
            plants = db.GetPlants(searchTextBox.Text);

            //Populates DGV with Plant list
            plantsDataGridView.DataSource = plants;

            //hides unneeded columns from data list
            plantsDataGridView.Columns[0].Visible = false;
            plantsDataGridView.Columns[3].Visible = false;
            plantsDataGridView.Columns[4].Visible = false;
            plantsDataGridView.Columns[5].Visible = false;
            plantsDataGridView.Columns[6].Visible = false;
            plantsDataGridView.Columns[7].Visible = false;

            //Changes column headers so that the labels are more clear
            plantsDataGridView.Columns[1].HeaderText = "Common Name:";
            plantsDataGridView.Columns[2].HeaderText = "Scientific Name:";

            //Changes second column to italics and makes font slightly larger than default value
            plantsDataGridView.Columns[2].DefaultCellStyle.Font = new Font("Courier New", 15, FontStyle.Italic);
        }

        private void CancelSelected()
        {
            //Clears plantInfoForm data so a clean form will be opened
            plantSelected = false;
            addNewButton.Text = "Add New";
            plantInfoEditForm.plantId = 0;
            plantInfoEditForm.commonNameTextBox.Text = plantInfoEditForm.botanicalNameTextBox.Text = plantInfoEditForm.waterRequirementTextBox.Text =
                plantInfoEditForm.lightRequirementTextBox.Text = plantInfoEditForm.fertilizerRequirementTextBox.Text = plantInfoEditForm.moreInfoTextBox.Text = "";
            plantInfoEditForm.plantPictureBox.Image = null;
        }               
      
        private void PopulateDataFromTable()
        {
            //Selects plant and assigns plantID/textboxes/image from SQL table
            plantSelected = true;
            plantInfoDisplayForm.plantId = Convert.ToInt32(plantsDataGridView.CurrentRow.Cells[0].Value.ToString());
            plantInfoDisplayForm.commonNameTextBox.Text = plantsDataGridView.CurrentRow.Cells[1].Value.ToString();
            plantInfoDisplayForm.botanicalNameTextBox.Text = plantsDataGridView.CurrentRow.Cells[2].Value.ToString();
            plantInfoDisplayForm.lightRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[3].Value.ToString();
            plantInfoDisplayForm.waterRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[4].Value.ToString();
            plantInfoDisplayForm.fertilizerRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[5].Value.ToString();
            plantInfoDisplayForm.moreInfoTextBox.Text = plantsDataGridView.CurrentRow.Cells[6].Value.ToString();
            plantInfoDisplayForm.plantPictureBox.Image = byteArrayToImage((byte[])plantsDataGridView.CurrentRow.Cells[7].Value);
            plantInfoEditForm.addPlantButton.Text = "Save";

            //Pulls up plantInfoDisplayForm
            this.Hide();
            plantInfoDisplayForm.ShowDialog();
            this.Close();
        }

        public void DeletePlant()
        {
            //Deletes currently selected plant form list/datagridview using delete button from form 
            DataAccess db = new DataAccess();
            db.DeletePlant(plantInfoEditForm.plantId);
            MessageBox.Show("Plant Deleted Successfully");
            UpdateBinding();
            addNewButton.Text = "Add New";
            deleteButton.Enabled = false;
        }

        private void OpenPlantInformationForm()
        {
            // Closes current form and opens PlantInformationForm            
            this.Hide();
            plantInfoEditForm.ShowDialog();
            this.Close();
            plantSelected = false;
        }

        //Converts a Byte Array to image for display
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
