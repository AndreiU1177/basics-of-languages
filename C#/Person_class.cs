using System;
namespace CSHARP
{
    public /*abstract*/ class User
    //abstract class cannot be instantiated
    {
        public User(string name){
            MiddleName = name;
            Console.WriteLine("Welcome, " + MiddleName);
        }
        //string status = "active";  //field (private)
        public string FirstName {get; set;}  //properties
        public string LastName {get; set;}
        public string MiddleName {get;}  //read only property
        //it can be assigned only once, in the constructor
        public string FullName {  //property version of GetFullName() method
            get{
                return FirstName + ' ' + LastName;
            }
        }
        
        public string GetFullName(){  //instance method
            return FirstName + ' ' + LastName;
        }

        public static void PrintSmth(User n){  //static method, not requiring an instance
            Console.WriteLine("Static method");
            Console.WriteLine(n.GetFullName());
        }

        public static void Sum(int a, int b){  //function overloading
            Console.WriteLine(a+b);
            Console.WriteLine("2 numbers");
        }

        public static void Sum(int a, int b, int c){
            Console.WriteLine(a+b+c);
            Console.WriteLine("3 numbers");
        }
        
        public override string ToString()  //function overriding
        {
            return "I DONT WANT";
        }

        public override bool Equals(object obj)  //overriding Object.Equals()
        {
            if( ((User) obj).FullName == FullName)
                return true;
            return false;
        }

        public override int GetHashCode()  //overriding GetHashCode()
        //integer value that is associated with each object
        {
            return FullName.GetHashCode();
        }

        public virtual void Introduction(){  //virtual method
        //created for overriding
            Console.WriteLine("Hi, i am the user!");
        }

        //public abstract void isGraduated();  //abstract class, forced to be overriden
        //works only if the class is abstract
    }
}