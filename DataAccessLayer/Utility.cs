using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Utility
    {
        public static void SaveLibraryItems(string isbnNo, string title, string author, string type, string location, string url, string volume, string issue, int clone) {

            _TablesTableAdapters.LibraryItemsTableAdapter libraryItemsAdapter = new _TablesTableAdapters.LibraryItemsTableAdapter();
            _Tables.LibraryItemsDataTable dtLibraryItemsTable = new _Tables.LibraryItemsDataTable();

            libraryItemsAdapter.Fill(dtLibraryItemsTable);

            
            while (clone > 0)
            {
                _Tables.LibraryItemsRow newLibraryItemRow = dtLibraryItemsTable.NewLibraryItemsRow();
                newLibraryItemRow.Title = title;
                newLibraryItemRow.ISBNNo = isbnNo;
                newLibraryItemRow.Author = author;
                newLibraryItemRow.Type = type;
                newLibraryItemRow.Location = location;
                newLibraryItemRow.URL = url;
                newLibraryItemRow.Volume = volume;
                newLibraryItemRow.Issue = issue;

                dtLibraryItemsTable.AddLibraryItemsRow(newLibraryItemRow);
                libraryItemsAdapter.Update(dtLibraryItemsTable);
                clone--;
            }
        }
    }
}
