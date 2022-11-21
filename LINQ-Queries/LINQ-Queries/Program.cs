using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoQueries
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        static void Main(string[] args)
        {
            List<Student>Students = new List<Student>();
            
           Students.Add( new Student { ID = 101, Name = "Pravallika", Marks = 90 });



            Students.Add(new Student { ID = 102, Name = "Rohit", Marks = 95 });

           Students.Add( new Student { ID = 103, Name = "Priya", Marks = 100 });


            // To Count the no.of Students
            Console.WriteLine("Total count of students:");
            Console.WriteLine(Students.Count);
            Console.ReadLine();

            //To find the Maximun ID
           var result = Students.Max(x => x.ID);
            Console.WriteLine("Maximum ID in the list of students:");
          Console.WriteLine(result);
            Console.ReadLine();

            //To find the Minimum ID
            var result1 = Students.Min(x => x.ID);
            Console.WriteLine("Minimum ID in the list of students:");
            Console.WriteLine(result1);
            Console.ReadLine();

            //To display list of students using select 
            Console.WriteLine(" list of students:");
            var result4 = Students.Select(x => new { x.ID, x.Name, x.Marks});
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //OrderBy
            IEnumerable<Student> result5 = Students.OrderBy(x => x.Name);
            foreach(Student item in result5)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();

            //OrderByDescending
            IEnumerable<Student> result6 = Students.OrderByDescending(x => x.ID);
            Console.WriteLine("ID of students in descending order");
            foreach (Student item in result6)
            {
                
                Console.WriteLine(item.ID);
            }
            Console.ReadLine();

            //OrderBy,ThenBY,ThenByDescending
            IEnumerable<Student> result7 = Students.OrderBy(x => x.Marks).ThenBy(x => x.Name);
            Console.WriteLine("sorting the order of students:");
            foreach (Student item in result7)
            {
                Console.WriteLine(item.Name+ "\t" +item.Marks);
            }
            Console.ReadLine();

            //Reverse
            var result8 = Students.Select(x => new { x.ID, x.Name, x.Marks }).Reverse();
            Console.WriteLine("list of students in reverse order");
            foreach (var item in result8)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
















        }
    }
}
