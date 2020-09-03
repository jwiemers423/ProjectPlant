using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class DeletePlant
    {
        public static void deletePlant(DataGridView plantDGV, TextBox searchBox, Button deleteButton)
        {
            //Deletes currently selected plant form list/datagridview using delete button from form 
            DataAccess db = new DataAccess();
            db.DeletePlant(PlantInformationEditForm.plantId);
            MessageBox.Show("Plant Deleted Successfully");
            UpdateBinding.updateBinding(plantDGV, searchBox);
            deleteButton.Enabled = false;
        }
    }
}
