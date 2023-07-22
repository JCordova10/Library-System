using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{

    public class Journal : LibraryItem
    {
        private string _journalId;
        

        public string JournalID {
            get { return _journalId; }
            set 
            {
                if (!value.StartsWith("J"))
                {
                    throw new ArgumentOutOfRangeException("Journal ID", "Must start with a capital \"J\" : (example:J#####)");
                }
                
                _journalId = value; }
        }
        
       public Journal() { }

        public Journal (string ID, string isbnNo, string title, string author, string type, string location) : base(isbnNo, title, author, type, location) {
            
            JournalID = ID;
            
        }

        public override string ClassObject()
        {
            return "Journal";
        }

        public override void PrintBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine("********* Journal Info: ***************");
            Console.WriteLine("Journal ID: " + _journalId);
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
    }   }    
}
