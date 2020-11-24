using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            int sum = numbers.Sum();
            double average = numbers.Average();
            Console.Write("Sum: ");
            Console.WriteLine(sum);
            Console.Write("Average: ");
            Console.WriteLine(average);
            //Order numbers in ascending order and decsending order. Print each to console.
            var ascending = numbers.OrderBy(x => x);
            Console.WriteLine("Print Ascending");
            foreach (var item in ascending)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.WriteLine("Print Descending");

            var descending = numbers.OrderByDescending(x => x);
            foreach (var item in descending)
            {
                Console.WriteLine(item);
            }
            //Print to the console only the numbers greater than 6
            var numsGreater6 = numbers.Where(x => x > 6);

            Console.WriteLine("----------------");
            Console.WriteLine("Printing nums > 6");
            foreach (var item in numsGreater6)
            {
                Console.WriteLine(item);
            }

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("--------------");
            Console.WriteLine("Printing only 4 items");

            var only4 = numbers.OrderBy(x => x).Take(4);
            foreach (var item in only4)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("--------------");
            Console.WriteLine("Change value at index 4 to my age and print in descending order");
            //Change the value at index 4 to your age, then print the numbers in decsending order


            Console.WriteLine("------------------");
            Console.WriteLine("Printing numbers in descending order with my age inserted at index 4");
            numbers[4] = 42;

            //var insertAge = numbers.SetValue()
            
            var descWithMyAge = numbers.OrderByDescending(x => x);
            foreach(var item in descWithMyAge)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            Console.WriteLine();

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            Console.WriteLine("Printing Employees with First Name start with C or S");
            var onlyCS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"));
            foreach(var item in onlyCS)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Printing Employees first name and last name that are over 26");
            Console.WriteLine("-------------------");

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var ageFirstLastOrder = employees.Where(x => x.Age > 26).OrderBy(y => y.FirstName).ThenBy(z => z.LastName);
            foreach(var item in ageFirstLastOrder)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} and his/her age is  {item.Age}");
            }

            //Print the Sum and then the Average of the employees' YearsOfExperience
            Console.WriteLine("--------------------");
            Console.WriteLine("Printing Emloyees sum of years of experience");
            var sumEmpYearsOfExp = employees.Sum(x => x.YearsOfExperience);
            Console.WriteLine(sumEmpYearsOfExp);

            Console.WriteLine("Printing Average years of experience");
            Console.WriteLine("-------------------------------");
            var averageYearsOfExp = employees.Average(x => x.YearsOfExperience);
            Console.WriteLine(averageYearsOfExp);
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            //Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("Adding employes wit 10 years or less experience and age greater than 35");
            Console.WriteLine("-----------------------");
            var empLessOrEqual10 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            foreach(var item in empLessOrEqual10)
            {
                Console.WriteLine($"{item.FullName}; years of experience is {item.YearsOfExperience} and age is {item.Age}");
            }

            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
