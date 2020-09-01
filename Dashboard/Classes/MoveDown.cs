using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    //Commands for "down" keypress. Moves column selection down one
    public class MoveDown
    {
        public static void moveDown()
        {
            MainForm mainForm = new MainForm();
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
    }
}
