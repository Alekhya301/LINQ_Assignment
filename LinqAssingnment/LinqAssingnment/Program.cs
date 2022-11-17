using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqAssingnment
{
    internal class Employee
    {
        public int ID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
        static void Main(string[] args)
        {
            List<Employee> Emp = new List<Employee>();
            Employee Emp1 = new Employee();
            Emp1.ID = 1001;
            Emp1.FirstName = "Malcolm";
            Emp1.LastName = "Daruwalla";
            Emp1.Title = "Manager";
            Emp1.DOB = Convert.ToDateTime("1984, 11, 16");
            Emp1.DOJ = Convert.ToDateTime("2011,6,8");
            Emp1.City = "Mumbai";
            Emp.Add(Emp1);

            Employee Emp2 = new Employee();
            Emp2.ID = 1002;
            Emp2.FirstName = "Asdin";
            Emp2.LastName = "Dhalla";
            Emp2.Title = "AsstManager";
            Emp2.DOB = Convert.ToDateTime("1984, 08, 20");
            Emp2.DOJ = Convert.ToDateTime("2012,7,7");
            Emp2.City = "Mumbai";
            Emp.Add(Emp2);

            Employee Emp3 = new Employee();
            Emp3.ID = 1003;
            Emp3.FirstName = "Madhavi";
            Emp3.LastName = "Oza";
            Emp3.Title = "Consultant";
            Emp3.DOB = Convert.ToDateTime("1987, 11, 14");
            Emp3.DOJ = Convert.ToDateTime("2015,12,4");
            Emp3.City = "Pune";
            Emp.Add(Emp3);

            Employee Emp4 = new Employee();
            Emp4.ID = 1004;
            Emp4.FirstName = "Saba";
            Emp4.LastName = "Shaikh";
            Emp4.Title = "SE";
            Emp4.DOB = Convert.ToDateTime("1990, 06, 03");
            Emp4.DOJ = Convert.ToDateTime("2016,2,2");
            Emp4.City = "Pune";
            Emp.Add(Emp4);

            Employee Emp5 = new Employee();
            Emp5.ID = 1005;
            Emp5.FirstName = "Nazia";
            Emp5.LastName = "Shaikh";
            Emp5.Title = "SE";
            Emp5.DOB = Convert.ToDateTime("1991, 03, 08");
            Emp5.DOJ = Convert.ToDateTime("2016,2,2");
            Emp5.City = "Mumbai";
            Emp.Add(Emp5);

            Employee Emp6 = new Employee();
            Emp6.ID = 1006;
            Emp6.FirstName = "Amit";
            Emp6.LastName = "Pathak";
            Emp6.Title = "Consultant";
            Emp6.DOB = Convert.ToDateTime("1989, 11, 07");
            Emp6.DOJ = Convert.ToDateTime("2014,8,8");
            Emp6.City = "Chennai";
            Emp.Add(Emp6);

            Employee Emp7 = new Employee();
            Emp7.ID = 1007;
            Emp7.FirstName = "Vijay";
            Emp7.LastName = "Natrajan";
            Emp7.Title = "Consultant";
            Emp7.DOB = Convert.ToDateTime("1989, 12, 2");
            Emp7.DOJ = Convert.ToDateTime("2015,6,1");
            Emp7.City = "Mumbai";
            Emp.Add(Emp7);

            Employee Emp8 = new Employee();
            Emp8.ID = 1008;
            Emp8.FirstName = "Rahul";
            Emp8.LastName = "Dubey";
            Emp8.Title = "Associate";
            Emp8.DOB = Convert.ToDateTime("1993, 11, 11");
            Emp8.DOJ = Convert.ToDateTime("2014,11,6");
            Emp8.City = "Chennai";
            Emp.Add(Emp8);

            Employee Emp9 = new Employee();
            Emp9.ID = 1009;
            Emp9.FirstName = "Suresh";
            Emp9.LastName = "Mistry";
            Emp9.Title = "Associate";
            Emp9.DOB = Convert.ToDateTime("1992, 08, 12");
            Emp9.DOJ = Convert.ToDateTime("2014,12,3");
            Emp9.City = "Chennai";
            Emp.Add(Emp9);

            Employee Emp10 = new Employee();
            Emp10.ID = 1010;
            Emp10.FirstName = "Sumit";
            Emp10.LastName = "Shah";
            Emp10.Title = "Manager";
            Emp10.DOB = Convert.ToDateTime("1991, 04, 12");
            Emp10.DOJ = Convert.ToDateTime("2016,1,2");
            Emp10.City = "Pune";
            Emp.Add(Emp10);

            var result = Emp.Select(x => new { x.ID, x.FirstName, x.LastName, x.Title, x.DOB, x.DOJ, x.City });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("******************************************");

            IEnumerable<Employee> result1 = Emp.Where(e => e.City != "Mumbai");
            foreach (Employee item in result1)
            {
                Console.WriteLine("List of Employees Whose CITY is not MUMBAI:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");
            }
            Console.ReadLine();

            Console.WriteLine("******************************************");

            IEnumerable<Employee> Result2 = Emp.Where (y => y.Title == "AsstManager");
            foreach(Employee item in Result2)
            {
                Console.WriteLine("List of Employees Whose TITLE is ASSTMANAGER:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");

            }
            Console.ReadLine();

            Console.WriteLine("******************************************");
            IEnumerable<Employee> Result3 = Emp.Where(z => z.LastName[0] == 'S');
            foreach (Employee item in Result3)
            {
                Console.WriteLine("List of Employees Whose LASTNAME starts with 'S':");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");

            }
            Console.ReadLine();
            Console.WriteLine("******************************************");

            IEnumerable<Employee> Result4 = Emp.Where(a => a.Title == "Associate" || a.Title == "Consultant");
            foreach( Employee item in Result4)
            {
                Console.WriteLine("List of Employees whose title is ASSOCIATE and CONSULTANT:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");
            }
            Console.ReadLine();
            Console.WriteLine("******************************************");

            var Result5 = Emp.Select(a => a.ID);
            Console.WriteLine("Total no.of Employees={0}",Result5.Count());
            Console.ReadLine();
            Console.WriteLine("******************************************");

            IEnumerable<Employee> Result6 = Emp.Where(x => x.City == "Chennai");
            foreach(Employee item in Result6)
            {
                Console.WriteLine(" Employee who belong to Chennai:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");

            }
            Console.ReadLine();
            Console.WriteLine("******************  ****************************");

            var Result7 = Emp.Select(x => x.ID); 
                Console.WriteLine("Highest Employee ID={0}",Result7.Max());
            Console.ReadLine();
            Console.WriteLine("**********************************************");

            IEnumerable<Employee> result8 = Emp.Where(e => e.Title != "Associate");
            foreach (Employee item in result8)
            {
                Console.WriteLine("List of Employees Whose designation is not Associate:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");
            }
            Console.ReadLine();

            Console.WriteLine("******************************************");

            var Result9 = Emp.Select(a => a.City);
            Console.WriteLine("Total no.of Employees ={0}", Result5.Count());
            Console.ReadLine();
            Console.WriteLine("******************************************");

            var Result10 = Emp.Select(x => x.DOJ);
            Console.WriteLine("Youngest Employee = {0}", Result10.Min());
            Console.ReadLine();
            Console.WriteLine("**********************************************");

            IEnumerable<Employee> Result11 = Emp.Where(e => e.DOJ < Convert.ToDateTime("2015,1,1"));
            foreach(Employee item in Result11)
            {
                Console.WriteLine("List of Employees Joined before 1/1/2015:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");

            }
            Console.ReadLine();
            Console.WriteLine("**********************************************");

            IEnumerable<Employee> Result12 = Emp.Where(e => e.DOB > Convert.ToDateTime("1990,1,1"));
            foreach (Employee item in Result12)
            {
                Console.WriteLine("List of Employees whose DOB is after 1/1/1990:");
                Console.WriteLine("" + item.ID + "  ,  " + item.FirstName + " , " + item.LastName + " , " + item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City + "");

            }
            Console.ReadLine();
            Console.WriteLine("**********************************************");

            IEnumerable<Employee>Result13 = Emp.Where(x => x.DOJ > Convert.ToDateTime("2015,1,1"));
            Console.WriteLine("Total No.of employees who joined after 1/1/2015 = {0}", Result13.Count());
            Console.ReadLine();
            Console.WriteLine("**********************************************");

            var Result14 = Emp.GroupBy(x => new { x.City, x.Title });
           foreach(var item in Result14)
            {
                Console.WriteLine("{0}----{1}", item.Key, item.Count()); 
            }
            Console.ReadLine();
            Console.WriteLine("**********************************************");















        }



    }
}