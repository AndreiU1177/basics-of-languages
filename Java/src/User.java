import java.util.List;
//an abstract class can work without abstract methods, so the methods inside
//can be used in derived class by calling them with "super" keyword
public class User {
	
	public User() {  //constructor
		System.out.println("Creating object...");
	}
	
	public User(boolean a) {  //overloading
		if(a) System.out.println("Creating real user...");
		else System.out.println("Creating fake user...");
	}
	
	private String firstName;  //field
	public String lastName;  //property
	public enum status{online, offline, away};  //enum
	//special "class" that represents a group of constants
	//can be used in a switch statement
	public status status;
	
	public void Welcoming() {  //instance method
		System.out.println("Welcome, " + firstName + " " + lastName + "!");
	}
	
	public final static void printUsers(List<User> u) {  //static method
	//final methods cannot be overridden
		int nr=1;
		for(User user : u) {
			System.out.println("User " + nr + ": " + user.getFirstName());
			nr++;
		}
	}
	
	public String getFirstName() {  //getter
		return firstName;
	}
	
	public void setFirstName(String fn) {  //setter
		this.firstName = fn;
	}
	
	public void sayHello() {  //virtual method
		System.out.println("I am a user!");
	}
	//can be overridden in derived class
	//any non-static and non-private method is virtual (can be overridden)
	
	//public abstract void dealDamage();  //abstract method
	//has to be overriden, also requires an abstract class
}
