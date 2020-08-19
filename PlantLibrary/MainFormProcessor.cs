using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlantLibrary
{
    public class MainFormProcessor
    {
        List<Pane> plants = new List<Plant>();
        public PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
        public PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
        public static bool plantSelected = false;

        public void UpdateBinding()
        {
            DataAccess db = new DataAccess();
            plants = db.GetPlants(mainForm.searchTextBox.Text);

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
            mainForm.plantsDataGridView.Columns[1].HeaderText = "Common Name:";
            mainForm.plantsDataGridView.Columns[2].HeaderText = "Scientific Name:";

            //Changes second column to italics and makes font slightly larger than default value
            mainForm.plantsDataGridView.Columns[2].DefaultCellStyle.Font = new Font("Courier New", 15, FontStyle.Italic);
        }

        public void CancelSelected()
        {
            //Clears plantInfoForm data so a clean form will be opened
            plantSelected = false;
            addNewButton.Text = "Add New";
            plantInfoEditForm.plantId = 0;
            plantInfoEditForm.commonNameTextBox.Text = plantInfoEditForm.botanicalNameTextBox.Text = plantInfoEditForm.waterRequirementTextBox.Text =
                plantInfoEditForm.lightRequirementTextBox.Text = plantInfoEditForm.fertilizerRequirementTextBox.Text = plantInfoEditForm.moreInfoTextBox.Text = "";
            plantInfoEditForm.plantPictureBox.Image = null;
        }

        //Commands for "up" keypress. Moves column selection up one
        public void moveUp()
        {
            if (mainForm.plantsDataGridView.RowCount > 0)
            {
                if (mainForm.plantsDataGridView.SelectedRows.Count > 0)
                {
                    int rowCount = mainForm.plantsDataGridView.Rows.Count;
                    int index = mainForm.plantsDataGridView.SelectedCells[0].OwningRow.Index;

                    if (index == 0)
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = mainForm.plantsDataGridView.Rows;

                    // remove the previous row and add it behind the selected row.
                    DataGridViewRow prevRow = rows[index - 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index, prevRow);
                    mainForm.plantsDataGridView.ClearSelection();
                    mainForm.plantsDataGridView.Rows[index - 1].Selected = true;
                }
            }
        }

        //Commands for "down" keypress. Moves column selection down one
        public void moveDown()
        {
            if (mainForm.plantsDataGridView.RowCount > 0)
            {
                if (mainForm.plantsDataGridView.SelectedRows.Count > 0)
                {
                    int rowCount = mainForm.plantsDataGridView.Rows.Count;
                    int index = mainForm.plantsDataGridView.SelectedCells[0].OwningRow.Index;

                    if (index == (rowCount - 2)) // include the header row
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = mainForm.plantsDataGridView.Rows;

                    // remove the next row and add it in front of the selected row.
                    DataGridViewRow nextRow = rows[index + 1];
                    rows.Remove(nextRow);
                    nextRow.Frozen = false;
                    rows.Insert(index, nextRow);
                    mainForm.plantsDataGridView.ClearSelection();
                    mainForm.plantsDataGridView.Rows[index + 1].Selected = true;
                }
            }
        }
        public void PopulateDataFromTable()
        {
            //Selects plant and assigns plantID/textboxes/image from SQL table
            plantSelected = true;
            plantInfoDisplayForm.plantId = Convert.ToInt32(mainForm.plantsDataGridView.CurrentRow.Cells[0].Value.ToString());
            plantInfoDisplayForm.commonNameTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[1].Value.ToString();
            plantInfoDisplayForm.botanicalNameTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[2].Value.ToString();
            plantInfoDisplayForm.lightRequirementTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[3].Value.ToString();
            plantInfoDisplayForm.waterRequirementTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[4].Value.ToString();
            plantInfoDisplayForm.fertilizerRequirementTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[5].Value.ToString();
            plantInfoDisplayForm.moreInfoTextBox.Text = mainForm.plantsDataGridView.CurrentRow.Cells[6].Value.ToString();
            plantInfoDisplayForm.plantPictureBox.Image = byteArrayToImage((byte[])mainForm.plantsDataGridView.CurrentRow.Cells[7].Value);
            plantInfoEditForm.addPlantButton.Text = "Save";

            //Pulls up plantInfoDisplayForm
            this.mainForm.Hide();
            plantInfoDisplayForm.ShowDialog();
            this.mainForm.Close();
        }

        public void DeletePlant()
        {
            //Deletes currently selected plant form list/datagridview using delete button from form
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess db = new DataAccess();
                db.DeletePlant(plantInfoEditForm.plantId);
                MessageBox.Show("Plant Deleted Successfully");
                UpdateBinding();
                mainForm.addNewButton.Text = "Add New";
                mainForm.deleteButton.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        public void OpenPlantInformationForm()
        {
            // Closes current form and opens PlantInformationForm            
            this.mainForm.Hide();
            plantInfoEditForm.ShowDialog();
            this.mainForm.Close();
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
