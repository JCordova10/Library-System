using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    class LibraryCatalog
    {
       
        public List<LibraryItem> _libraryItem;
        public int _itemCount;

        public LibraryCatalog() {
            
            _libraryItem = new List<LibraryItem>();
        }

        public void RemoveAnItem(LibraryItem libraryItem) {
            _libraryItem.Remove(libraryItem);
            _itemCount--;
        }
    }
}
