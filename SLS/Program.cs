using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLS
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {

            //try
            //{

            //    LibraryItem book1 = new Book("B1", "1234561", "The Goat", "JJ Hero", "Education", "First floor");
            //    LibraryItem book2 = new Book("B2", "1234562", "The Great Gatsby", "J Kennedy", "Education", "Second floor");
            //    LibraryItem eBook1 = new Ebook("E1", "7654315", "Ronaldo", "Joe Rogan", "Education", "First floor", "www.Book2.com");
            //    LibraryItem magazine1 = new Magazine("M1", "4673473", "Messi", "Tyler D", "Science", "Third floor", "1", "10");
            //    LibraryItem magazine2 = new Magazine("M2", "4673474", "Beach", "Dough Hill", "Science", "Third floor", "1", "2");
            //    LibraryItem journal1 = new Journal("J1", "3874345", "Beto", "Nancy Doe", "History", "Second floor");
            //    LibraryItem journal2 = new Journal("J2", "3874346", "Life Of Jerry", "Tom Pope", "History", "Second floor");


            //    LibraryCatalog library = new LibraryCatalog();
            //    Librarian librarian1 = new Librarian(library);

            //    librarian1.AddAnItem(book1);
            //    librarian1.AddAnItem(book2);
            //    librarian1.AddAnItem(eBook1);
            //    librarian1.AddAnItem((LibraryItem)book1.Clone());
            //    librarian1.AddAnItem(magazine1);
            //    librarian1.AddAnItem(magazine2);
            //    librarian1.AddAnItem(journal1);
            //    librarian1.AddAnItem(journal2);
                

            //    //Test to see if the correct input was provided for  S- student Number. W - Weber Number. If not throw excepetion.
            //    Person student2 = new Student("Joe", "Dirt", "S2234", "W22222", "3234 s 600 n Lehi, UT", "222222222");
            //    Person student1 = new Student("Candice", "Cordova", "S5555", "W11111", "1234 w 500 n Logan, UT", "111111111");
            //    Person instructor1 = new Instructor("Holly", "Qoo", "E1234", "W55555", "1234 W Ogden, UT", "1234-1234-2433");

            //    //Adding people to a list 
            //    List<Person> peopleList = new List<Person>();
            //    peopleList.Add(student1);
            //    peopleList.Add(student2);
            //    peopleList.Add(instructor1);
                

            //    //foreach (Person item in peopleList)
            //    //{

            //    //    Console.WriteLine(item);
            //    //}
                                             
            //    ///Student checks out items from the library
            //    student1.CheckOutAnItem(library._libraryItem[0]);
            //    student1.CheckOutAnItem(library._libraryItem[1]);
            //    student1.CheckOutAnItem(library._libraryItem[4]);
            //    student1.CheckOutAnItem(library._libraryItem[5]);

            //    student2.CheckOutAnItem(library._libraryItem[2]);
            //    student2.CheckOutAnItem(library._libraryItem[3]);
                
            //    //Student return a book to the library
            //    //student1.CheckAnItemIn(library._libraryItem[1]);

            //    //Instructor check out items from the library
            //    instructor1.CheckOutAnItem(library._libraryItem[0]);
            //    instructor1.CheckOutAnItem(library._libraryItem[5]);
            //    instructor1.CheckOutAnItem(library._libraryItem[6]);               

            //    //Removes a book from the system 
            //    //library.RemoveAnItem(library._libraryItem[2]);
                

            //    ///Prints out the Items in the library
            //    for (int i = 0; i < library._libraryItem.Count; i++) {
            //        library._libraryItem[i].PrintBookInfo();
            //    }
               
            //    //Prints out the the books a person has checked out
            //    student1.PrintPersonBookInfo();

            //    //Queries
            //    Console.WriteLine();
            //    Console.WriteLine("Enter Student Last Name:");
            //    string lastName = Console.ReadLine();

            //    var allItemsList = peopleList.Where(x => x.LastName == lastName && x is Student).Select(z => ((Student)z)._items).ToList();

            //    //Query 1
            //    var li = allItemsList[0];
            //    var books = li.Where(x => x is Book);
                
            //    Console.WriteLine("******************Pringing Query******************");
            //    foreach (Book item in books)
            //    {

            //        Console.WriteLine("Title: " + item._title + "\nDue Date: " + item._itemDueDate);
            //    }

            //    //Query 2
            //    Console.WriteLine();
            //    Console.WriteLine("Enter Student or Instructor Last Name:");
            //    string lName = Console.ReadLine();

            //    var ListItemsForStdntOrInstr = peopleList.Where(x => x.LastName == lName).ToList();
               
            //    var instructorItems = ListItemsForStdntOrInstr.Where(x => x is Instructor).Select(x => ((Instructor)x)._items).ToList();
            //    if (instructorItems.Count > 0) {
                    
            //        var instrucorList = instructorItems[0].OrderBy(x => x._dateItemReturned);
            //        foreach (LibraryItem item in instrucorList) {
            //            if (item != null) {
            //                Console.WriteLine("Title: " + item._title + "\nDue Date: " + item._itemDueDate);
            //            }
                        
            //        }
            //    }
                
            //    var studentItems = ListItemsForStdntOrInstr.Where(x => x is Student).Select(x => ((Student)x)._items).ToList();
            //    if (studentItems.Count > 0)
            //    {

            //        var studentList = studentItems[0].OrderBy(x => x._dateItemReturned);
            //        foreach (LibraryItem item in studentList)
            //        {
            //            if (item != null)
            //            {
            //                Console.WriteLine("Title: " + item._title + "\nDue Date: "+  item._itemDueDate + "\n");
            //            }
            //        }
            //    }

            //}
            //catch (ArgumentOutOfRangeException argumentOutOfRangeException) {
            //    Console.WriteLine("Error: " + argumentOutOfRangeException);
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryForm());


            Console.ReadLine();
        }
    }
}
