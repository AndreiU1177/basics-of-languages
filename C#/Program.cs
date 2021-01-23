using System;
using System.Collections.Generic;
using System.Linq;

namespace CSHARP  //used for organization
{
    class Program  //contains multiple members
    {
        //int x = 19;  //global scoped variable
        //can be used anywhere inside the class
        static void Main(string[] args)  //method
        //static methods can be called without using an instance/object
        //instance methods must be called with an instance/object
        /*
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Another line!");
            Console.WriteLine(args[1]);  //printing an argument

            //getting input from user
            string x = Console.ReadLine();
            Console.WriteLine(x);
        }
        */

        /*
        {
            int[] a = {1,2,3,4};  //array
            int[] b = a;

            b[0] = 5;
            Console.WriteLine(a[0]);
            //b ISN'T a copy of array 'a', both point to the same array
        }
        */

        /*
        {
            float x = 5.5F;
            double y = 4.6;  //most common used
            decimal z = 3.7M;  //most precise

            double a = double.NaN;  //not a number
            double g = double.PositiveInfinity;  //+Infinite
            //.NegativeInfinity for -Infinite  

            Console.WriteLine(Math.Abs(y));  //absolute value
            Console.WriteLine(Math.Max(x, y));  //max value
            //can also be done min value
            Console.WriteLine(Math.Round(z));  //rounds a number
            Console.WriteLine(Math.Floor(x));  //cuts the decimals
            //can also be used .Truncate
            Console.WriteLine(Math.Ceiling(z));  //cuts the decimals and adds 1
            Console.WriteLine(Math.Sign(g));  //returns the sign
        }
        */

        /*
        {
            char[] letters = {'I', 'o', 'n'};
            Console.WriteLine(letters);

            string name = "Andrei";
            string name2 = new string(letters) + ' ' + name;
            Console.WriteLine(name2);
            string message = $"My name is {name2}!";
            Console.WriteLine(message);
            Console.WriteLine(message.Length);  //lenght of string
            Console.WriteLine(message.IndexOf("is"));  //get index of a substring or char
            string message_c = message;
            Console.WriteLine(message_c.Remove(8, 2));
            //1st arg - start, 2nd - how many chars
            Console.WriteLine(message_c.Split(' '));  //split a string using a separator
            string[] b = message_c.Split(' ');
            Console.WriteLine(b[0]);


        }
        */

        /*
        {
            string name = "My name is \"Andrei\"";  //using double quotes inside a string
            string name2 = @"Hello \n my name\t is Bob";  //to interpret literally
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.Beep();  //beeps
        }
        */

        /*
        {
            Person user1 = new Person();  //create an object
            user1.FirstName = "Andrei";
            user1.LastName = "Bob";
            string NameGuess = Console.ReadLine();

            if (NameGuess == user1.GetFullName()){  //if-else statement
                Console.WriteLine("You guessed my name!");
            }
            else{
                Console.WriteLine("You dunno my name! Shame on you!");
            }
        }
        */

        /*
        {
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if (age>16 && password == "1234")  //using logical operators
                Console.WriteLine("Successfully registered!");
            else
                Console.WriteLine("Sorry");
        }
        */

        /*
        {
            Console.WriteLine("Enter number between 1 and 3");
            int guess = Int32.Parse(Console.ReadLine());
            switch(guess){  //switch satement
                case 1:
                    Console.WriteLine("Sorry!");
                    break;
                case 2:
                    Console.WriteLine("You got it!");
                    break;
                case 3:
                    Console.WriteLine("Lower number!");
                    break;
                default:
                    Console.WriteLine("Over the boundaries");
                    break;
            }
        }
        */

        /*
        {
            int age = 10;
            int a = (age >= 10) ? 1 : 2;  //ternary operator
            Console.WriteLine(a);
        }
        */

        /*
        {  //loops
            int i = 0;
            while(i<5){  //while loop
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do{  //do while loop
                Console.WriteLine(j);
                j++;
            }
            while (j<0);

            for (int k=0; k<10; k++){  //for loop
                Console.WriteLine(k);
            }
        }
        */

        /*
        {
            //nested for loops
            for(int i = 0; i<10; i++){
                for(int j = 0; j<i; j++){
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //nested while loops
            int a = 0, b;
            while(a<10){
                b=0;
                while(b<a){
                    Console.Write("#");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
        */

        /*
        {
            int i;
            for(i = 10; i>0; i--){
                Console.WriteLine(i);
                if(i==5) break;  //gets out of the loop
            }

            for(i = 10; i>0; i--){
                if(i%2 == 0) continue;  //skips the iteration
                Console.Write(i);
            }
        }
        */

        /*
        {
            int[] numbers = new int[10];
            int[] grades = {9, 10, 10, 8};  //array with known valus
            for(int i = 0; i<grades.Length; i++){  //loop through array
                Console.WriteLine(grades[i]);
            }

            for(int k = 0; k < numbers.Length; k++){
                numbers[k] = Int32.Parse(Console.ReadLine());
            }

            for(int j = 0; j < numbers.Length; j++){
                Console.Write(numbers[j] + " ");
            }
        }
        */

        /*
        {
            int[] nums = {1, 67, 2, -5};
            Console.WriteLine(Array.IndexOf(nums, 3));  //index of specified element
            //returns -1 if not found
            Array.Sort(nums);
            foreach(var item in nums) Console.Write(item + " ");  foreach loop
            Array.Reverse(nums);  //reverse the array
            int[] gaga = {67, 2, 1, -5};
            if(Enumerable.SequenceEqual(nums, gaga)){  //checks if 2 arrays have the same values
                Console.WriteLine("Identical arrays");
            }
        }
        */

        /*
        {
            //multidimensional arrays
            int[,] grades = new int[3, 4];  //2D array
            int[,] numbers = {  //2D array with known valus
                {1, 2, 3},
                {4, 5, 6}
            }; 
            int[][] jagged_arr = {  //jagged array
                new int[]{1, 2, 3},
                new int[]{1, 2, 3, 10, 5},
                new int[]{1}
            };

            for(int i = 0; i < jagged_arr.Length; i++){  //loop through jagged array
                for(int k = 0; k < jagged_arr[i].Length; k++){
                    Console.Write(jagged_arr[i][k] + " ");
                }
                Console.WriteLine();
            }
            */

            /*
            {
                List<int> grades = new List<int>() {1, 3};
                grades.Add(9);  //add element to list
                grades.Insert(1, 4);
                Console.WriteLine(grades[2]);  //insert an element
                //if index is used, it will push the entire list
                //index must be in range
                //grades.Clear();  //clear the list
                grades.Remove(1);  //removes the first occurence
                //pushes the list
                Console.WriteLine(grades.Contains(3));  //checks if list contains an item
                Console.WriteLine(grades.IndexOf(3, 3));  //first occurence
                //returns -1 if not found
                Console.WriteLine(grades.LastIndexOf(3));  //last occurence
                var x = grades;
                Console.WriteLine(grades.Equals(x));  //points to the same entity
                Console.WriteLine(grades.SequenceEqual(x));  //checks if lists contain same values
                Console.WriteLine(grades.Count);  //length of list

            }
            */

            /*
            {
                List<List<int>> grades = new List<List<int>>() {
                    new List<int>{1, 2},
                    new List<int>{3, 4, 5, 6},
                    new List<int>{7},
                    new List<int>{8, 9, 10}
                    };

                foreach(List<int> sub in grades){  //foreach for nested loops
                    foreach(int item in sub){
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
            */

            /*
            {
                List<int> a = new List<int>(){1, 2};
                int[] b = a.ToArray();  //convert list to array
                List<int> c = b.ToList();  //convert array to list
                Console.WriteLine(c.GetType());

                c.Reverse();  //reverse a list
                foreach(int item in c) Console.Write(item + " ");
                c.Sort();  //sort a list
                foreach(int item in c) Console.Write(item + " ");
            }
            */

            /*
            {
                User me = new User();
                me.FirstName = "Andrei";
                me.LastName = "Bob";
                Console.WriteLine("My name is: " + me.FullName);

                User user1 = new User();
                user1.FirstName = "Dan";
                user1.LastName = "Balan";
                List<User> users = new List<User>();  //list of custom class
                users.Add(me);
                users.Add(user1);

                foreach(User it in users){
                    Console.WriteLine(it.FirstName);
                }
            }
            */

            /*
            {
                //creating list of users given their names
                List<string> firstNames = new List<string>(){
                    "Andrei",
                    "Dan"
                };
                List<string> lastNames = new List<string>(){
                    "Bob",
                    "Balan"
                };

                List<User> users = new List<User>();
                for(int i=0; i<firstNames.Count; i++){
                    User user = new User();
                    user.FirstName = firstNames[i];
                    user.LastName = lastNames[i];
                    users.Add(user);
                }

                foreach(User it in users){
                    Console.WriteLine(it.FullName);
                }
            }
            */

            /*
            {
                User a = new User();
                a.FirstName = "ANdrei";
                a.LastName = "SALAA";
                User.PrintSmth(a);  //static method
                //isn't called from an instance
            }
            */

            /*
            {
                User.Sum(4,5);
                User.Sum(4,5,6);
                //function overloading used only when you have a different number
                //of paramaters or if you have different type of parameters

                User me = new User();
                me.FirstName = "Andrei";
                me.LastName = "Bob";

               Console.WriteLine(me);  //overridden toString method
            }
            */

            /*
            {
                User me = new User();
                me.FirstName = "andrei";

                User you = new User();
                you.FirstName = "andrei";
                Console.WriteLine(me.GetHashCode());
                Console.WriteLine(you.GetHashCode());
            }
            */


            {
                //class Student inherits from User class
                //a Student object can use all the properties and methods of User class
                Student me = new Student("whatever");
                me.FirstName = "Dan";
                me.LastName = "TheNerd";
                Console.WriteLine(me.graduated);
                User you = new User("Dorothy");
                you.Introduction();  //virtual overriden method
                me.Introduction();
                Student he = new Student("Richard");
                Console.WriteLine(he.FullName);
                iTalk us = new Student("Paul");
                us.Introduction();
            }
        }
    }
