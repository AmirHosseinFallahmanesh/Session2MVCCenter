using System;
using System.Linq;

namespace Part1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new SampleContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //  InsertDemo1(context);

            // FindDemo(context);



            // Delete1(context);

            //  Delete2(context);
            // UpdateDemo1(context);

            UpdateDemo2(context);
            var data = context.Authors.ToList();
            Console.WriteLine("Done");
            Console.Read();
        }

        private static void UpdateDemo2(SampleContext context)
        {
            Author author = new Author() { AuthorId = 1, FirstName = "amirali", LastName = "alavi", Age = 1 };
            context.Authors.Update(author);
            context.SaveChanges();
        }

        private static void UpdateDemo1(SampleContext context)
        {
            var auther = context.Authors.Find(1);
            auther.Age = 58;
            context.SaveChanges();
        }

        private static void Delete2(SampleContext context)
        {
            Author author = new Author() { AuthorId = 3 };
            context.Authors.Remove(author);
            context.SaveChanges();
        }

        private static void Delete1(SampleContext context)
        {
            var auther = context.Authors.Find(2);
            context.Authors.Remove(auther);
            context.SaveChanges();
        }


        private static void FindDemo(SampleContext context)
        {
            var data = context.Authors.ToList();
            var data1 = context.Authors.Where(a => a.Age > 40).ToList();
            var data2 = context.Authors.Where(a => a.FirstName.StartsWith("a")).ToList();
            var data3 = context.Authors.First(a => a.Age < 80);
            var data4 = context.Authors.FirstOrDefault(a => a.Age > 80);
            // var data5 = context.Authors.Single(a => a.Age > 80);
            var data6 = context.Authors.SingleOrDefault(a => a.Age > 80);
            var data7 = context.Authors.Find(2);


            foreach (var item in data2)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }
        }

        private static void InsertDemo1(SampleContext context)
        {
            Console.WriteLine("Created");
            var author = new Author
            {
                FirstName = "amir",
                LastName = "amiri",
                Age=50
            };
            context.Authors.Add(author);

            var author1 = new Author
            {
                FirstName = "reza",
                LastName = "rezaii",
                Age=42
            };
            context.Authors.Add(author1);
            var author2 = new Author
            {
                FirstName = "amin",
                LastName = "amini",
                Age = 33
            };
            context.Authors.Add(author2);
            context.SaveChanges();
        }
    }
}
