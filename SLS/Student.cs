using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    class Student : Person
    {
        private string _studentId;
        public int MAX_ITEMS_ALLOWED = 3;
        public LibraryItem[] _items;
        
        public string StudentId {
            get { return _studentId; }
            set {
                if (!value.StartsWith("S")) {
                    throw new ArgumentOutOfRangeException("StudentId", "Must start with a capital \"S\" : (example:S###########)");
                }
                _studentId = value;
            }
        }
        public Student() { }

        public Student(string fName, string lName, string studentId,string wNo, string address, string ssn) : base(fName, lName, wNo, address, ssn)
        {
            StudentId = studentId;
            _noOfItemsCheckedOut = 0;
            _items = new LibraryItem[MAX_ITEMS_ALLOWED];

        }

        public override void CheckOutAnItem(LibraryItem libraryItem)
        {
            if (CheckOutMaxReached())
            {
                Console.WriteLine();
                Console.WriteLine(FirstName + " "+ LastName + ": You have reached the checkout limit. Please return a book to checkout a new one");
                Console.WriteLine();
            }
            else
            {
                if (libraryItem.IsItemCheckedOut())
                {
                    Console.WriteLine(FirstName +" "+ LastName + ": " + "Item is already checked out.");
                    Console.WriteLine();
                }
                else
                {
                    _items[_noOfItemsCheckedOut] = libraryItem;
                    libraryItem._itemCheckedOut = "Yes";
                    _noOfItemsCheckedOut++;
                    libraryItem._itemCheckOutDate = DateTime.Today;

                    if (libraryItem.ClassObject() == "Book")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(1);
                    }
                    if (libraryItem.ClassObject() == "EBook")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(3);
                    }
                    if (libraryItem.ClassObject() == "Magazine")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddDays(7);
                    }
                    if (libraryItem.ClassObject() == "Journal")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(2);
                    }

                }
            }
        }

        public override void PrintStudentInfo()
        {
            Console.WriteLine("**********Student Information**********");
            Console.WriteLine("Student Name: " + FirstName +" "+ LastName);
            Console.WriteLine("Booked checked out by student: " + _noOfItemsCheckedOut);
            
        }

        public override void PrintPersonBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******************* Checked Out Books by " + FirstName +" "+ LastName + " *******************");

            for (int i = 0; i < _items.Length - 1; i++)
            {

                if (_items[i]._itemCheckedOut != "No" && _items[i] != null)
                {
                    _items[i].PrintBookInfo();
                    Console.WriteLine("Due Date: " + _items[i]._itemDueDate);
                }
            }
        }
    }
}
