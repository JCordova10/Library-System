using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    public class Ebook : Book
    {
        private string _eBookId;
        public string _eBookURL;

        public string EBookID
        {
            get{return _eBookId;}
            set
            {
                if (!value.StartsWith("E"))
                {
                    throw new ArgumentOutOfRangeException("Book ID", "Must start with a capital \"E\" : (example:E#####)");
                }
                _eBookId = value;
            }
        }

        public Ebook() { }
        public Ebook(string ID, string isbnNo, string title, string author, string type, string location, string url) : base(isbnNo, title, author, type, location)
        {
            EBookID = ID;
            this._eBookURL = url;
        }

        public override string ClassObject()
        {
            return "EBook";
        }

        public override void PrintBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine("********* eBook Info: ***************");
            Console.WriteLine("eBook ID: " + _eBookId);
            Console.WriteLine("ISBN: " + _isbnNo);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Type: " + _type);
            Console.WriteLine("Location: " + _itemLocation);
            Console.WriteLine("Is the book checked out? " + _itemCheckedOut);

        }
        public override decimal LateFee()
        {
            if (_dateItemReturned != _itemDueDate)
            {
                TimeSpan timespan = DateTime.Now - _itemDueDate;
                int daysOverdue = (int)Math.Ceiling(timespan.TotalDays);

                return daysOverdue * 0.50m;
            }
            else
            {
                return 0.00m;
            }
        }
    }
}
