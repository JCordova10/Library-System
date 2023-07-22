using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    public abstract class LibraryItem : ICloneable, ILateFee
    {       
        public string _isbnNo;
        public string _title;
        public string _author;
        public string _type;
        public string _itemLocation;
        public string _itemCheckedOut = "No";
        public DateTime _itemCheckOutDate;
        public DateTime _dateItemReturned;
        public DateTime _itemDueDate;

        public LibraryItem() { }
        
        public LibraryItem( string isbnNo, string title, string author, string type, string location) {
            
            this._isbnNo = isbnNo;
            this._title = title;
            this._author = author;
            this._type = type;
            this._itemLocation = location;
                
        }

        public bool IsItemCheckedOut()
        {
            if (_itemCheckedOut == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void CheckAnItemIn(LibraryItem libraryItem)
        {
            libraryItem._itemCheckedOut = "No";
            _dateItemReturned = DateTime.Today;

        }

        public bool ItemDueDate()
        {
            if (_dateItemReturned > _itemDueDate)
            {
                Console.WriteLine("Library item is late! Due Date was : " + _itemDueDate);
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual object Clone()
        {
            return this;
        }

        public decimal ChargeFee()
        {
            return LateFee();
        }

        public override string ToString()
        {
            return "ISBN: " + _isbnNo + "\n Title: " + _title;
        }

        public virtual void CheckOutAnItem(LibraryItem libraryItem) { }
        public virtual void PrintBookInfo() { }
        public abstract decimal LateFee();
        public abstract string ClassObject();


    }
}
