public class Student extends User {  //Student inherits from User
	public String major;
	
	@Override
	public void sayHello() {
		super.sayHello();  //Invoke Parent Class Method
		System.out.println("Hi, i am a student!");
	}
}
