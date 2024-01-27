using System.ComponentModel;

namespace LINQ
{
    internal class Program
    {
        //1
        public static List<string> words = new List<string>()
        {
            "ahmed","alam","asem"
        };

        //2
        public static List<int> numbers = new List<int>()
        {
            21, 123, 12, 1, 2, 230, 8
        };

        //3
        public static List<float> nums = new List<float>()
        {
            4.5f, 4.2f, 4.6f, 4.7f, 4.9f, 5, 6, 3, 4,7, 4.4f
        };

        //4
        public static List<string> wordss = new List<string>()
        {
            "eat","create","meat","Heart","Attack","Ransom"
        };

        //5
        public static List<string> wordds = new List<string>()
        {
            "eat","create","meat","Heart","Attack","Ransom"
        };

        //6
        public static List<string> Most = new List<string>()
        {
            "panda", "n093nfv034nie9", "abdullah", "amar"
        };

        //7

        public static List<string> Dup = new List<string>()
        {
            "abc", "xyz", "klm", "xyz", "abc", "abc", "rst"
        };

        // 10
        public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {

            // 1 - Write a query that returns words starting with letter 'a' and ending with letter 'm'.
            Console.WriteLine("1- ");
             var Words = (from word in words
                         where word.StartsWith("a") && word.EndsWith("m")
                         select word).ToList();
             // var Words = words.Select(word => word.StartsWith("a") && word.EndsWith("m")).ToList();
             foreach (var e in Words) { Console.WriteLine(e); }

            // 2 - Write a query that returns top 5 numbers from the list of integers in descending order.
            Console.WriteLine("2- ");
            var Numbers = (from number in numbers
                           orderby number descending
                           select number).Take(5).ToList();

             //var Numbers = numbers.OrderByDescending(number => number).Take(5).ToList();
             foreach (var e in Numbers) { Console.WriteLine(e); }

            //3-Write a query that returns list of numbers and their squares only if square is greater than 20
            Console.WriteLine("3- ");
            var Nums = (from number in nums
                           where number * number > 20
                           select number).ToList();

             //var Numbers = numbers.Where(number => number * number > 20).ToList();
             foreach (var e in Nums) { Console.WriteLine(e); }

            //4-Write a query that replaces 'ea' substring with astersik (*) in given list of words.
            Console.WriteLine("4- ");
            Console.WriteLine("----- First -----");
            var Wordss = (from word in wordss
                         where word.Contains("ea")
                         select word.Replace("ea", "*")).ToList();
            foreach (var e in Wordss) {  Console.WriteLine(e); }
            Console.WriteLine("----- Another -----");
            foreach (var word in wordss)
            {
                Console.WriteLine(word.Replace("ea", "*"));
            }

            //5 - Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
            Console.WriteLine("5- ");
            
            var WordsContainsE = (from word in wordds
                                  orderby word ascending
                                  where  word.Contains("e")
                                  select word).ToList();

             //var Wordds = wordds.OrderBy(word => word);
             //var WordsContainsE = Wordds.Where(word => word.Contains("e"));

            foreach (var e in WordsContainsE) {  Console.WriteLine(e); }


            //6-Write a query that returns most frequent character in string. Assume that there is only one such character.
            // Expected input and output
            // "panda" → 'a'
            //"n093nfv034nie9"→ 'n'

            //NOTWORK
            Console.WriteLine("6- ");
            //First
            //var MostFrequentChar = from word in Most
            //select word.GroupBy(x => x).OrderByDescending(x => x).First().Key;

            //Second
            //var MostFrequentChar = Most.Where(word => word.GroupBy(x => x).OrderByDescending(x => x).First().Key); 

            //foreach (var word in MostFrequentChar) { Console.WriteLine(word); }

            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

            var MostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            Console.WriteLine(MostFrequentCharacter);

            //7-Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
            //Expected input and output
            //["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]
            Console.WriteLine("7- ");
            //var NonDup = (from word in Dup
                         // where (Dup.Where(wordd => wordd == word).Count() == 1)
                         // select word).ToList();

            var NonDup = Dup.Where(word => (Dup.Where(wordd => wordd == word).Count() == 1));
            foreach(var e in NonDup) { Console.WriteLine(e); }

            //8-Write a query that returns only uppercase words from string.
            //Expected input and output
            //"DDD example CQRS Event Sourcing" → DDD, CQRS
            Console.WriteLine("8- ");
            string Statement = "sjfaklf ajfakls AAAD DDD example CQRS Event Sourcing";

            var List = Statement.Split(" ");
            var UpperCase = from word in List
                            where word.ToUpper() == word
                            select word;

            var Upper = Statement.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));
            Console.WriteLine("----- First -----");
            foreach (var word in UpperCase) {  Console.WriteLine(word); }
            Console.WriteLine("----- Second -----");
            foreach (var word in Upper) { Console.WriteLine(word); }

            //11
            Employee employee = new Employee();
            employee.Name = "Test"; employee.Salary = 10;employee.Id = 1;employee.DepartmentNumber = 1;
            employee.Address = "Cairo";
            Employee employee1 = new Employee();
            employee1.Name = "Test1"; employee1.Salary = 100; employee1.Id = 2; employee1.DepartmentNumber = 1;
            employee1.Address = "Cairo";

            Employee employee2 = new Employee();
            employee2.Name = "Test2"; employee2.Salary = 1000; employee2.Id = 3; employee2.DepartmentNumber = 2;
            employee2.Address = "Alex";

            Employee employee3 = new Employee();
            employee3.Name = "Test3"; employee3.Salary = 10000; employee3.Id = 4; employee3.DepartmentNumber = 2;
            employee3.Address = "Alex";

            Employee employee4 = new Employee();
            employee4.Name = "Test4"; employee4.Salary = 100000; employee4.Id = 5; employee4.DepartmentNumber = 3;
            employee4.Address = "Aswan";

            // 11
            employees.Add(employee);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            // 12 - Write a query that returns sum of salaries.
            Console.WriteLine("12- ");
            var SumSalaries = employees.Sum(x => x.Salary);
            var Sum = (from employe in employees
                       select employe.Salary).Sum();
            Console.WriteLine(SumSalaries);
            Console.WriteLine(Sum);

            // 13-Write a query that returns max salary.
            Console.WriteLine("13- ");
            var MaxSalary = employees.Max(x => x.Salary);

            var Max = (from employe in employees
            select employe.Salary).Max();

            Console.WriteLine(MaxSalary);
            Console.WriteLine(Max);

            // 14-Write a query that returns employees with address is Cairo.
            Console.WriteLine("14- ");
            // var AddressCairo = employees.Where(x => x.Address == "Cairo");
            var AddressCairo = (from employe in employees
                               where employe.Address == "Cairo"
                               select employe).ToList();
            foreach(var emp in AddressCairo) Console.WriteLine(emp.Id);

            // 15-Write a query that returns groups of employees according to department.
            Console.WriteLine("15- ");
            var EmpDEP = employees.Where(x => x.DepartmentNumber == 2).ToList();
            //var Employees = from employe in employees
                            //where employe.DepartmentNumber == 1
                            //select employe;
            foreach (var emp in EmpDEP) Console.WriteLine(emp.Id);


            //16-Write a query that returns the count of employees.
            Console.WriteLine("16- ");
            //var EmoCount = employees.Count();
            var CountEMP = (from employe in employees
            select employe.Id).Count();
            Console.WriteLine(CountEMP);

            //17-Write a query that returns count of employee that has salary > 5000.
            Console.WriteLine("17- ");
            //var EmpSal = employees.Where(x => x.Salary > 5000).Count();
            var EmpSal = (from emp in employees
                         where emp.Salary > 5000
                         select emp).Count();
            Console.WriteLine(EmpSal);

        }

    }
}
