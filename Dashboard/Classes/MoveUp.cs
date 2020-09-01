using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    //Commands for "up" keypress. Moves column selection up one
    public class MoveUp
    {
        public static void moveUp()
        {
            MainForm mainForm = new MainForm();
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
    }
}
