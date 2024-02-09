using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreDataGridViewState
{

    /* Example for usage: (Note that KenDgvCharacteristics handles the very rare situation where CurrentRow is null)
     *   // Note: ColumnOfKeyCell must be a column with int values.
     *   KenDgvCharacteristics kenDgvCharacteristics = new KenDgvCharacteristics(
     *                  dataGridView1, ColumnOfKeyCell, columnForSettingCurrentCell);
     *   refreshScreen();
     *   kenDgvCharacteristics.RestoreDgvCharacteristics();
     */

    /// <summary>
    /// KenDgvCharacteristics: Contains characteristics (state) of a DataGridView that can be saved in order
    /// to restore the DataGridView to its saved state after it is refreshed/updated.
    /// Same state means:
    /// 1. Datagridview will be sorted as it was when state saved.
    /// 2. Datagridview will be scrolled to the position such that
    ///     the selected row is exactly where it was when state was saved.
    /// IMPORTANT: If the DataGridView is handling events for CurrentCellChanged (perhaps to display details in a separate panel for the current row)
    ///             then that event will occur when the DataGridView is restored.
    /// </summary>
    public class KenDgvCharacteristics
    {
        public bool CharacteristicsAreValid { get; set; }
        public DataGridView TargetDataGridView { get; set; }
        public DataGridViewColumn ColumnOfKeyCell { get; set; }
        // 8/31/2023 .NET has a bug: If columnForSettingCurrentCell is first visible column then the cell won't always
        //          be highlighted later when you make it the current cell!  It fails on last row and first row.
        //          So don't specify the first visible column!
        public DataGridViewColumn ColumnForSettingCurrentCell { get; set; }
        public int OffsetFromFirstDisplayedScrollingRowIndex { get; set; }
        public int KeyCellValue { get; set; }
        public DataGridViewColumn SortedColumn { get; set; }
        public ListSortDirection SortDirection { get; set; }
        public KenDgvCharacteristics(DataGridView targetDataGridView, DataGridViewColumn columnForKeyCell, DataGridViewColumn columnForSettingCurrentCell)
        {
            if (targetDataGridView.CurrentRow == null)
            {
                CharacteristicsAreValid = false;
            }
            else
            {
                CharacteristicsAreValid = true;
                TargetDataGridView = targetDataGridView;
                ColumnOfKeyCell = columnForKeyCell;
                ColumnForSettingCurrentCell = columnForSettingCurrentCell;
                int firstDisplayedScrollingRowIndex = TargetDataGridView.FirstDisplayedScrollingRowIndex;
                int currentRowIndex = TargetDataGridView.CurrentRow.Index;
                OffsetFromFirstDisplayedScrollingRowIndex = currentRowIndex - firstDisplayedScrollingRowIndex;
                KeyCellValue = (int)TargetDataGridView.CurrentRow.Cells[columnForKeyCell.Index].Value;
                SortedColumn = TargetDataGridView.SortedColumn;
                SortDirection = TargetDataGridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            }
        }
        /// <summary>
        /// Restores DataGridViewCharacteristics to a saved state.
        /// </summary>
        public void RestoreDgvCharacteristics()
        {
            int selectedRowIndex = -1;
            if ((CharacteristicsAreValid == true) && (TargetDataGridView.Rows.Count > 0))
            {
                // sort as saved earlier
                if (SortedColumn != null)
                {
                    TargetDataGridView.Sort(SortedColumn, SortDirection);
                }
                // find (and set) the cell which should be CurrentCell
                foreach (DataGridViewRow dgvrow in TargetDataGridView.Rows)
                {
                    object nextValue = (int)dgvrow.Cells[ColumnOfKeyCell.Index].Value;
                    if (nextValue.Equals(KeyCellValue))
                    {
                        TargetDataGridView.ClearSelection();
                        // Usability: Select cell that was acted on after screen is refreshed
                        TargetDataGridView.CurrentCell = dgvrow.Cells[ColumnForSettingCurrentCell.Index];
                        selectedRowIndex = dgvrow.Index;
                        break;
                    }
                }
                if (selectedRowIndex > 0)
                {
                    int desiredScrollIndex = Math.Max(selectedRowIndex - OffsetFromFirstDisplayedScrollingRowIndex, 0);
                    TargetDataGridView.FirstDisplayedScrollingRowIndex = desiredScrollIndex;
                }
            }
        }
    }
}
