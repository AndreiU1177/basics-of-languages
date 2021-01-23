using System;
namespace CSHARP
{
    public class Student : User, iTalk  //Student inherits from User
    //implementing an interface
    {
        public Student(string name) : base(name)
        {  //constructor to assing to read only properties
        //it can contain parameters
        }
        public bool graduated{get; set;} = false;  //default value
        public override void Introduction()  //overriden virtual method
        {
            Console.WriteLine("Hi, i am a Student, but i am also a User");
        }

        /*public override void isGraduated()  //overriden abstract method
        //works only if the class that it inherits from is abstract
        {
            if(graduated == false){
                Console.WriteLine("I haven't graduated yet");
            }
            else{
                Console.WriteLine("I graduated! I am a full-grown man");
            }
        }*/
        
    }
}