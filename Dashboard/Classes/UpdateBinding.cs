using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    class UpdateBinding
    {
        public static void updateBinding(DataGridView dataGridView, TextBox searchTextBox)
        {
            List<Plant> plants = new List<Plant>();
            DataAccess db = new DataAccess();
            plants = db.GetPlants(searchTextBox.Text);

            //Populates DGV with Plant list
            dataGridView.DataSource = plants;

            //hides unneeded columns from data list
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;

            //Changes column headers so that the labels are more clear
            dataGridView.Columns[1].HeaderText = "Common Name:";
            dataGridView.Columns[2].HeaderText = "Scientific Name:";

            //Changes second column to italics and makes font slightly larger than default value
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font("Courier New", 15, FontStyle.Italic);
        }
    }
}
