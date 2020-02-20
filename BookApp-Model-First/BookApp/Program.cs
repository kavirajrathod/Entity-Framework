using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Program
    { 
       static BookContext ctx = new BookContext();
       static void Main(string[] args)
          {                  
              //  InsertInitialData();
                ShowAll();

                Console.ReadKey();
            }

            private static void ShowAll()
            {
                var books = ctx.Books;
                Console.WriteLine("Books Data:\n");
                foreach (var cst in books)
                {
                    Console.WriteLine("{0}\t\t{1}", cst.Title, cst.Price);
                }

                var authors = ctx.Authors;
                Console.WriteLine("\n\nAuthors Data:\n");
                foreach (var pdt in authors)
                {
                    Console.WriteLine("{0}\t\t{1}", pdt.Author_name , pdt.Author_Address);
                }


                var details = ctx.Details;
                Console.WriteLine("\n\nDetails Data:\n");
                Console.WriteLine("{0,-8}  {1,-9}  {2,-8}  {3,-10}  {4,6:N}  {5,5}  {6,15}", "P_num", "Bid", "Title", "Price", "AuthorID", "Authorname", "AuthorAddress");
                foreach (var pr in details)
                {
                    Console.WriteLine("{0,-8}\t{1,-14}\t{2,-8}Rs{3,-15}\t{4,8:N}\t{5,6}\t{6,9}"
                          , pr.P_num, pr.Books.Bid, pr.Books.Title,pr.Books.Price, pr.Authors.Aid,
                          pr.Authors.Author_name,pr.Authors.Author_Address );
                }

            }

            private static void InsertInitialData()
            {
                var books = new List<Book>
            {
             new Book { Title="AgniPath",Price=250},
             new Book { Title="SkyIsPink",Price=350},
             new Book { Title="Jwala    ",Price=100},
             new Book { Title="AspiringMind",Price=210}           
            };
               books.ForEach(s => ctx.Books.Add(s));
                ctx.SaveChanges();


                var authors = new List<Author>
            {
             new Author { Author_name="Raghunath Mashalkar",Author_Address="Mumbai"},
             new Author { Author_name="PL Deshpande",Author_Address="Pune"},
             new Author { Author_name="Harivanshrai Bachhan",Author_Address="Mumbai"},
             new Author { Author_name="Dr.APJ Abdul Kalam",Author_Address="Chennai"}          
            };
                authors.ForEach(p => ctx.Authors.Add(p));
                ctx.SaveChanges();

                var details = new List<Details>
            {
             new Details{P_num=120,Bid=1,Aid=2 },
             new Details{P_num=120,Bid=2,Aid=2 },
             new Details{P_num=120,Bid=3,Aid=3 },
             new Details{P_num=120,Bid=4,Aid=4 }
            };

                details.ForEach(pp => ctx.Details.Add(pp));
                ctx.SaveChanges();


            }


        }
    }
