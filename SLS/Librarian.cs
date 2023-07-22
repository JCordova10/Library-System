using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    class Librarian : Person
    {
        
        public string _employeeId;
        public LibraryCatalog _catalog;

        public Librarian(LibraryCatalog catalog) {
            this._catalog = catalog;
        }

        public Librarian(string fName, string lName, string address, string ssn, string Id, LibraryCatalog catalog) : base(fName, lName, address, ssn, Id)
        {
            this._catalog = catalog;
            _employeeId = Id;
        }

        public void AddAnItem(LibraryItem libraryItem)
        {
            _catalog._libraryItem.Add(libraryItem);
            _catalog._itemCount++;
        }           
    }
}
