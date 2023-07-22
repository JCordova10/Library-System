using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    public class Book : LibraryItem, ICloneable
    {
        public string _bookId;
        
        
        public string BookID
        {
            get{return _bookId;}
            set
            {
                if (!value.StartsWith("B"))
                {
                    throw new ArgumentOutOfRangeException("Book ID", "Must start with a capital \"B\" : (example:B#####)");
                }
                _bookId = value;
            }
        }
        
        public Book() { } 

        public Book(string ID, string isbnNo, string title, string author, string type, string location) : base(isbnNo, title, author, type, location) {
            BookID = ID;
        }

        public Book(string isbnNo, string title, string author, string type, string location) : base(isbnNo, title, author, type, location) { } 

        public override void CheckOutAnItem(LibraryItem libraryItem) {
            libraryItem._itemCheckOutDate = DateTime.Today;
            libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(1);
        }


        public override void PrintBookInfo()
        {
            
            Console.WriteLine();
            Console.WriteLine("********* Book Info: ***************");
            Console.WriteLine("Book ID: " + _bookId);
            Console.WriteLine("ISBN: " + _isbnNo);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Type: " + _type);
            Console.WriteLine("Location: " + _itemLocation);
            Console.WriteLine("Is the book checked out? " + _itemCheckedOut);
            

        }

        public override string ClassObject()
        {
            return "Book";
        }

    

        public override object Clone()
        {
            int num;

            var libraryItem = (Book)this.MemberwiseClone();
            String removeChar = libraryItem._bookId;
            removeChar = removeChar.Substring(1);
            num = int.Parse(removeChar);
            num++;
            removeChar = num.ToString();
            removeChar = removeChar.Insert(0, "B");
            libraryItem._bookId = removeChar;
            
            return libraryItem;                     
        }

        public override decimal LateFee()
        {
            if (_dateItemReturned != _itemDueDate)
            {
                TimeSpan timespan = DateTime.Now - _itemDueDate;
                int daysOverdue = (int)Math.Ceiling(timespan.TotalDays);

                return daysOverdue * 1.00m;
            }
            else {
                return 0.00m;
            }
            
        }   
    }
}
