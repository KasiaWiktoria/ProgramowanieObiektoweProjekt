using System;
using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        public List<Reader> Readers { get; set; }
        public Catalogue Catalogue { get; set;  }

        public Library()
        {
            this.Catalogue = new Catalogue();
            this.Readers = new List<Reader>();
        }

        public void AddReader(Reader reader)
        {
            
        }

        public void CheckOut(String name, String surname, String title, String author)
        {
            
        }

        public void CheckOut(int id, String title, String author)
        {

        }

        public void AddToCatalogue(LibItem libItem)
        {
            
        }

        public void PrintTheBestReader()
        {
            
        }
        
        public void PrintReadersList()
        {
            Console.WriteLine("\n Readers in this library:");
            foreach (Reader reader in Readers)
            {
                Console.WriteLine(reader);
            }
        }

        public void PrintReadersBySurname()
        {
            Readers.Sort((reader1, reader2) => reader1.Surname.CompareTo(reader2.Surname));
            PrintReadersList();
        }

        public void PrintReadersByNumberOfCheckOuts()
        {
            Readers.Sort((reader1, reader2) => reader2.NumberOfCheckOuts.CompareTo(reader1.NumberOfCheckOuts));
            PrintReadersList();
        }
    }
}
