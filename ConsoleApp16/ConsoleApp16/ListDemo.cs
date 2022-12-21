using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Author
{
    
    public string Name { get; set; }
    public string Book { get; set; }
    public double Price { get; set; }
    public string AuthorDetails()
    {
        return string.Format("{0} is an author of {1}. Price: ${2}",
            Name, Book, Price);
    }
}


class Program
{
    static void main()
    {
        Console.WriteLine("Hello List!");
        ListIntro();
    }

    public static void ListIntro()
    {
       
        List<int> numbers = new List<int>(5) { 5, 10, 15, 20, 25 };
        
        numbers.Add(30);
        numbers.Add(35);
        numbers.Add(40);
        
        int[] prime = new int[] { 1, 3, 5, 7, 11, 13 };
        numbers.AddRange(prime);

     
        numbers.Insert(2, 22);
        numbers.Insert(3, 33);

      
        numbers.InsertRange(5, new int[] { 11, 22, 33, 44, 55 });

     
        foreach (int num in numbers)
        {
            Console.Write($"{num}, ");
        }

        Console.WriteLine();

     
        List<string> names = new List<string>()
                            {"Mahesh Chand", "Neel Beniwal", "Chris Love" };
     
        names.Add("Author One");
        names.Add("Author Two");
        names.Add("Author Three");

        
        names.AddRange(new string[] { "Raj Beniwal", "Allen O'neill" });


        names.Insert(3, "Mahes        h Chand at 4th");

        
        names.InsertRange(2, new string[] { "Mahesh Beniwal", "Chand Beniwal", "Mahesh Chand Beniwal" });

        
        foreach (string name in names)
        {
            Console.Write($"{name}, ");
        }

        Console.WriteLine();


        List<Author> authors = new List<Author>
        {
            new Author { Name = "Mahesh Chand", Book = "ADO.NET Programming", Price = 49.95 },
            new Author { Name = "Neel Beniwal", Book = "Jump Ball", Price = 19.95 },
            new Author { Name = "Chris Love", Book = "Practical PWA", Price = 29.95 }
        };
        
        authors.Add(new Author { Name = "Mahesh Chand", Book = "Graphics with GDI+", Price = 49.95 });
        authors.Add(new Author { Name = "Mahesh Chand", Book = "Mastering C#", Price = 54.95 });
        authors.Add(new Author { Name = "Mahesh Chand", Book = "Jumpstart Blockchain", Price = 44.95 });

         List<Author> duplicateAuthors = new List<Author>
        {
            new Author { Name = "Mahesh Chand", Book = "ADO.NET Programming", Price = 49.95 },
            new Author { Name = "Neel Beniwal", Book = "Jump Ball", Price = 19.95 },
            new Author { Name = "Chris Love", Book = "Practical PWA", Price = 29.95 }
        };
        
        authors.AddRange(duplicateAuthors);



        authors.Insert(3, new Author { Name = "Mahesh Beniwal", Book = "New Graphics with GDI+", Price = 49.95 });


        List<Author> newAuthors = new List<Author>
        {
            new Author { Name = "Mahesh Chand", Book = "Database Programming", Price = 49.95 },
            new Author { Name = "Mahesh Chand Beniwal", Book = "C# Development", Price = 19.95 },
            new Author { Name = "Chand Beniwal", Book = ".NET Best Practices", Price = 29.95 }
        };
        
        authors.InsertRange(2, newAuthors);



        foreach (Author author in authors)
        {
            Console.WriteLine($"Author: {author.Name}:{author.Book}:{author.Price}");
        }

        Console.ReadKey();
    }
}