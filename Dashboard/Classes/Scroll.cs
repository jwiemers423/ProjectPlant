using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class ScrollDGV
    {
        public static void moveUp(DataGridView dataGridView)
        {
            if (dataGridView.RowCount > 0)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int rowCount = dataGridView.Rows.Count;
                    int index = dataGridView.SelectedCells[0].OwningRow.Index;

                    if (index == 0)
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = dataGridView.Rows;

                    // remove the previous row and add it behind the selected row.
                    DataGridViewRow prevRow = rows[index - 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index, prevRow);
                    dataGridView.ClearSelection();
                    dataGridView.Rows[index - 1].Selected = true;
                }
            }
        }
        public static void moveDown(DataGridView dataGridView)
        {
            if (dataGridView.RowCount > 0)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int rowCount = dataGridView.Rows.Count;
                    int index = dataGridView.SelectedCells[0].OwningRow.Index;

                    if (index == (rowCount - 2)) // include the header row
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = dataGridView.Rows;

                    // remove the next row and add it in front of the selected row.
                    DataGridViewRow nextRow = rows[index + 1];
                    rows.Remove(nextRow);
                    nextRow.Frozen = false;
                    rows.Insert(index, nextRow);
                    dataGridView.ClearSelection();
                    dataGridView.Rows[index + 1].Selected = true;
                }
            }
        }
    }
}
