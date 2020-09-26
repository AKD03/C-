using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Book
    {

        int id;
        string title;
        float price;
        string author;
        public int Bookid
        {
            get { return id; }
            set { id = value; }
        }
        public string Booktitle
        {
            get { return title; }
            set { title = value; }
        }
        public float Bookprice
        {
            get { return price; }
            set { price = value; }
        }
        public string Bookauthor
        {
            get { return author; }
            set { author = value; }
        }
        class Ass5
        {
            static void Main(string[] args)
            {
                Book b = new Book();
                b.id = 123;
                b.title = "Game of theones";
                b.price = 100;
                b.author = "George RR Martin";
                Console.Write("The book id ,title ,price and autor is {0} {1} {2} {3} ", b.id, b.title, b.price, b.author);

            }

        }
    }
}