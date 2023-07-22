using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
     class Instructor : Person
    {

        private string _instructorId;
        public int MAX_ITEMS_ALLOWED = 5;
        public LibraryItem[] _items;



        public string InstructorID {
            get { return _instructorId; }
            set {
                if (!value.StartsWith("E")) {
                    throw new ArgumentOutOfRangeException("InstuctorID", "Instructor ID must start with a capital \"E\"");
                }
                _instructorId = value;
            }
        }

        public Instructor() { }

        public Instructor(string fName, string lName, string InstructorId, string wNo, string address, string ssn) : base(fName, lName, wNo, address, ssn)
        {
           InstructorID = InstructorId;
            _noOfItemsCheckedOut = 0;
            _items = new LibraryItem[MAX_ITEMS_ALLOWED];

        }

        public override bool CheckOutMaxReached()
        {
            return _noOfItemsCheckedOut >= 5;
        }

        public override void CheckOutAnItem(LibraryItem libraryItem)
        {
            if (CheckOutMaxReached())
            {
                Console.WriteLine();
                Console.WriteLine(FirstName +" "+ LastName + ": You have reached the checkout limit. Please return a book to checkout a new one");
                Console.WriteLine();
            }
            else
            {
                if (libraryItem.IsItemCheckedOut())
                {
                    Console.WriteLine(FirstName +" "+ LastName + ": " + "Book is already checked out.");
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
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(2);
                    }
                    if (libraryItem.ClassObject() == "EBook")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(3);
                    }
                    if (libraryItem.ClassObject() == "Magazine")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddDays(14);
                    }
                    if (libraryItem.ClassObject() == "Journal")
                    {
                        libraryItem._itemDueDate = libraryItem._itemCheckOutDate.AddMonths(2);
                    }
                }
            }
        }

        public override void PrintInstructorInfo()
        {
            Console.WriteLine("**********Instructor Information**********");
            Console.WriteLine("Instructor Name: " + FirstName +" "+ LastName);
            Console.WriteLine("Booked checked out by instructor: " + _noOfItemsCheckedOut);
        }

        public override void PrintPersonBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine("*********Checked Out Books by " + FirstName + " "+ LastName + "********");

            for (int i = 0; i < _items.Length; i++)
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
