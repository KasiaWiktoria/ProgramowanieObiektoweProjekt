using System;
using System.Collections.Generic;

namespace Library
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Surname { get; }
        public List<LibItem> CheckOutList { get; set; }
        public int NumberOfCheckOuts { get; set; }

        public Reader(String name, String surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.NumberOfCheckOuts = 0;
            this.CheckOutList = new List<LibItem>();
        }

        public void CheckOut(LibItem libItem) { 
            
        }

        public void Return(LibItem libItem)
        {

        }

        public void PrintCheckOuts()
        {

        }

        public override string ToString()
        {
            return String.Format("{0} {1}       {2} check-outs", this.Name, this.Surname, this.NumberOfCheckOuts);
        }
    }
}
