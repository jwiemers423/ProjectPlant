
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantLibrary;

namespace FormUI
{
    public partial class MainForm : Form
    {
        List<Plant> plants = new List<Plant>();
        public PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
        public PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
        public static bool plantSelected = false;
              
        public MainForm()
        {
            MainFormProcessor mainFormLib = new MainFormProcessor();
            InitializeComponent();
            UpdateBinding();
        }

        //private void UpdateBinding()
        //{
        //    DataAccess db = new DataAccess();
        //    plants = db.GetPlants(searchTextBox.Text);

        //    //Populates DGV with Plant list
        //    plantsDataGridView.DataSource = plants;

        //    //hides unneeded columns from data list
        //    plantsDataGridView.Columns[0].Visible = false;
        //    plantsDataGridView.Columns[3].Visible = false;
        //    plantsDataGridView.Columns[4].Visible = false;
        //    plantsDataGridView.Columns[5].Visible = false;
        //    plantsDataGridView.Columns[6].Visible = false;
        //    plantsDataGridView.Columns[7].Visible = false;

        //    //Changes column headers so that the labels are more clear
        //    plantsDataGridView.Columns[1].HeaderText = "Common Name:";
        //    plantsDataGridView.Columns[2].HeaderText = "Scientific Name:";

        //    //Changes second column to italics and makes font slightly larger than default value
        //    plantsDataGridView.Columns[2].DefaultCellStyle.Font = new Font("Courier New", 15, FontStyle.Italic);
        //}

        //private void CancelSelected()
        //{
        //    //Clears plantInfoForm data so a clean form will be opened
        //    plantSelected = false;
        //    addNewButton.Text = "Add New";
        //    plantInfoEditForm.plantId = 0;
        //    plantInfoEditForm.commonNameTextBox.Text = plantInfoEditForm.botanicalNameTextBox.Text = plantInfoEditForm.waterRequirementTextBox.Text =
        //        plantInfoEditForm.lightRequirementTextBox.Text = plantInfoEditForm.fertilizerRequirementTextBox.Text = plantInfoEditForm.moreInfoTextBox.Text = "";
        //    plantInfoEditForm.plantPictureBox.Image = null;
        //}

        ////Commands for "up" keypress. Moves column selection up one
        //private void moveUp()
        //{
        //    if (plantsDataGridView.RowCount > 0)
        //    {
        //        if (plantsDataGridView.SelectedRows.Count > 0)
        //        {
        //            int rowCount = plantsDataGridView.Rows.Count;
        //            int index = plantsDataGridView.SelectedCells[0].OwningRow.Index;

        //            if (index == 0)
        //            {
        //                return;
        //            }
        //            DataGridViewRowCollection rows = plantsDataGridView.Rows;

        //            // remove the previous row and add it behind the selected row.
        //            DataGridViewRow prevRow = rows[index - 1];
        //            rows.Remove(prevRow);
        //            prevRow.Frozen = false;
        //            rows.Insert(index, prevRow);
        //            plantsDataGridView.ClearSelection();
        //            plantsDataGridView.Rows[index - 1].Selected = true;
        //        }
        //    }
        //}

        ////Commands for "down" keypress. Moves column selection down one
        //private void moveDown()
        //{
        //    if (plantsDataGridView.RowCount > 0)
        //    {
        //        if (plantsDataGridView.SelectedRows.Count > 0)
        //        {
        //            int rowCount = plantsDataGridView.Rows.Count;
        //            int index = plantsDataGridView.SelectedCells[0].OwningRow.Index;

        //            if (index == (rowCount - 2)) // include the header row
        //            {
        //                return;
        //            }
        //            DataGridViewRowCollection rows = plantsDataGridView.Rows;

        //            // remove the next row and add it in front of the selected row.
        //            DataGridViewRow nextRow = rows[index + 1];
        //            rows.Remove(nextRow);
        //            nextRow.Frozen = false;
        //            rows.Insert(index, nextRow);
        //            plantsDataGridView.ClearSelection();
        //            plantsDataGridView.Rows[index + 1].Selected = true;
        //        }
        //    }
        //}
        //private void PopulateDataFromTable()
        //{
        //    //Selects plant and assigns plantID/textboxes/image from SQL table
        //    plantSelected = true;
        //    plantInfoDisplayForm.plantId = Convert.ToInt32(plantsDataGridView.CurrentRow.Cells[0].Value.ToString());
        //    plantInfoDisplayForm.commonNameTextBox.Text = plantsDataGridView.CurrentRow.Cells[1].Value.ToString();
        //    plantInfoDisplayForm.botanicalNameTextBox.Text = plantsDataGridView.CurrentRow.Cells[2].Value.ToString();
        //    plantInfoDisplayForm.lightRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[3].Value.ToString();
        //    plantInfoDisplayForm.waterRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[4].Value.ToString();
        //    plantInfoDisplayForm.fertilizerRequirementTextBox.Text = plantsDataGridView.CurrentRow.Cells[5].Value.ToString();
        //    plantInfoDisplayForm.moreInfoTextBox.Text = plantsDataGridView.CurrentRow.Cells[6].Value.ToString();
        //    plantInfoDisplayForm.plantPictureBox.Image = byteArrayToImage((byte[])plantsDataGridView.CurrentRow.Cells[7].Value);
        //    plantInfoEditForm.addPlantButton.Text = "Save";

        //    //Pulls up plantInfoDisplayForm
        //    this.Hide();
        //    plantInfoDisplayForm.ShowDialog();
        //    this.Close();
        //}

        //private void DeletePlant()
        //{
        //    //Deletes currently selected plant form list/datagridview using delete button from form
        //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        DataAccess db = new DataAccess();
        //        db.DeletePlant(plantInfoEditForm.plantId);
        //        MessageBox.Show("Plant Deleted Successfully");
        //        UpdateBinding();
        //        addNewButton.Text = "Add New";
        //        deleteButton.Enabled = false;
        //    }
        //    else if (dialogResult == DialogResult.No)
        //    {
        //        return;
        //    }
        //}

        //private void OpenPlantInformationForm()
        //{
        //    // Closes current form and opens PlantInformationForm            
        //    this.Hide();
        //    plantInfoEditForm.ShowDialog();
        //    this.Close();
        //    plantSelected = false;
        //}

        ////Converts a Byte Array to image for display
        //public Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(ms);
        //    return returnImage;
        //}

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
            DeletePlant();
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
            //Deletes currnetly selected plant from list/datagridview using delete button from keyboard
            if (e.KeyCode == Keys.Delete)
            {
                DeletePlant();
            }

            //Move into PlantInfoDisplay for selected plant
            if (e.KeyCode == Keys.Enter)
            {
                PopulateDataFromTable();
            }

            //Changes which plant is currently selected with arrow keys on keyboard
            if (e.KeyCode == Keys.Up)
            {
                moveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown();
            }            
        }
    }
}
