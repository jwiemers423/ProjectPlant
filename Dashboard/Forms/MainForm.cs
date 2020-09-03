using System;
using System.Windows.Forms;


namespace FormUI
{
    public partial class MainForm : Form
    {        
        public static bool plantSelected = false;
              
        public MainForm()
        {
            InitializeComponent();
            UpdateBinding.updateBinding(plantsDataGridView, searchTextBox);
        }

        //Events
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Filters plants in sql by what is entered in the searchbar textbox
            UpdateBinding.updateBinding(plantsDataGridView, searchTextBox);
            if (plantSelected == true)
            {
                PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
                CancelSelected.cancelSelected(plantInfoEditForm);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this plant entry?", "Delete Plant", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeletePlant.deletePlant(plantsDataGridView, searchTextBox, deleteButton);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }        
        
        private void addNewButton_Click(object sender, EventArgs e)
        {
            PlantInformationEditForm plantInfoEditForm = new PlantInformationEditForm();
            CancelSelected.cancelSelected(plantInfoEditForm);
            OpenNewForm.mainToEditForm(this, plantInfoEditForm);
        }
               
        private void plantsDataGridView_Click(object sender, EventArgs e)
        {
            //Selects plant and assigns plant ID from SQL table         
            if (plantsDataGridView.CurrentRow.Index != -1)
            {
                plantSelected = true;
                deleteButton.Enabled = true;
                PlantInformationEditForm.plantId = Convert.ToInt32(plantsDataGridView.CurrentRow.Cells[0].Value.ToString());                
            }   
        }        
        private void plantsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
            PopulateDataFromTable.populateDataFromTable(plantsDataGridView, plantInfoDisplayForm);

            OpenNewForm.mainToDisplayForm(this, plantInfoDisplayForm);
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
                    DeletePlant.deletePlant(plantsDataGridView, searchTextBox, deleteButton);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            //Move into PlantInfoDisplay for selected plant
            if (e.KeyCode == Keys.Enter)
            {
                PlantInformationDisplayForm plantInfoDisplayForm = new PlantInformationDisplayForm();
                PopulateDataFromTable.populateDataFromTable(plantsDataGridView, plantInfoDisplayForm);

                this.Hide();
                plantInfoDisplayForm.ShowDialog();
                this.Close();
            }

            //Changes which plant is currently selected with arrow keys on keyboard
            if (e.KeyCode == Keys.Up)
            {
                ScrollDGV.moveUp(plantsDataGridView);
            }

            if (e.KeyCode == Keys.Down)
            {
                ScrollDGV.moveDown(plantsDataGridView);
            }
        }
    }
}
