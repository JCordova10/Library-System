using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLS
{
    public abstract class Person  
    {
        
        private string _wNumber;
        public int _noOfItemsCheckedOut;


        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string SSN { get; set; }
        
        public string WNumber {
            get { return _wNumber; }
            set {
                if (!value.StartsWith("W")) {
                    throw new ArgumentOutOfRangeException("WNumber", "Weber number must start with \"W\" ");
                }
                _wNumber = value;
            }
        }    

        public Person() { }

        public Person(string fName, string lName, string wNo, string address, string ssn) {
            FirstName = fName;
            LastName = lName;
            Address = address;
            WNumber = wNo;
            SSN = ssn;

        }

        public virtual bool CheckOutMaxReached()
        {
            return _noOfItemsCheckedOut >= 3;
        }

        public virtual void CheckOutAnItem(LibraryItem libraryItem) { }

        public virtual void CheckAnItemIn(LibraryItem libraryItem) { }

        public virtual void PrintStudentInfo() { }

        public virtual void PrintInstructorInfo() { }

        public virtual void PrintPersonBookInfo() { }
         
        public override string ToString() {
            return "\n Name: " + FirstName + " " + LastName + "\n Weber Number: " + WNumber + "\n Address: " + Address + "\n SSN: " + SSN ;
        }
        
    }
}

