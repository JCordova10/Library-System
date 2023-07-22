using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    internal class Magazine : LibraryItem
    {
        private string _magazineId;
        public string _volume;
        public string _issue;


        public string MagazineID
        {
            get { return _magazineId; }
            set
            {
                if (!value.StartsWith("M"))
                {
                    throw new ArgumentOutOfRangeException("Magazine ID", "Must start with a capital \"M\" : (example:M#####)");
                }
                _magazineId = value;
            }
        }

        public Magazine() { }

        public Magazine(string ID, string isbnNo, string title, string author, string type, string location, string volume, string issue) : base(isbnNo, title, author, type, location)
        {

            MagazineID = ID;
            this._volume = volume;
            this._issue = issue;

        }

        public override string ClassObject()
        {
            return "Magazine";
        }

        public override void PrintBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine("********* Magazine Info: ***************");
            Console.WriteLine("Magazine ID: " + _magazineId);
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
