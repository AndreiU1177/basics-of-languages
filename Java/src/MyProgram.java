import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class MyProgram {

	@SuppressWarnings("static-access")
	public static void main(String[] args)  //member of the class
	/*
	{
		System.out.println("Hello world!");  //method with arguments
		Scanner input = new Scanner(System.in);  //creating scanner998 object
		int number = input.nextInt();  //input integer
		String name = input.nextLine();  //input string
		System.out.println("The number you entered is: " + number);
		System.out.println("The string you entered is: " + name);
		input.close();
		//each type of input has its specific scanner method
	}
	*/
	
	/*
	{
		String name = "Andrei";
		//strings are objects, not primitives
		//the rest are primitives
		int x = 5;
		long b = 7171l;
		float y = 4.5f;
		double z = 10.4;
		final int DAYS_OF_WEEK = 7;  //constant variable
		boolean isValid = true;
		char letter = 'c';
		System.out.println((int) letter);  //dec code from ascii
	}
	*/
	
	/*
	{
		System.out.println(Integer.MIN_VALUE);  //absolute minimum value
		System.out.println(Integer.SIZE);  //size in bits
		System.out.println(Integer.BYTES);  //size in bytes
		System.out.println(Double.NEGATIVE_INFINITY);  //negative infinity
		//also has positive infinity
		System.out.println(Double.NaN);  //not a number
		System.out.println(10.5/3);  //real number division
		String nr = "100";
		int a = Integer.parseInt(nr);  //convert string to int
		String a1 = Integer.toString(a);  //convert int to string
	}
	*/
	
	/*
	{
		String x = "Hello ";
		System.out.println(x.charAt(1));  //char at specific index
		String a = String.format("Hello, you are: %s", "one", "optional");  //format a string
		System.out.println(a);
		System.out.println(a.length());  //length of a string
		x = x.toLowerCase();  //convert to lower case
		//can also convert to upper case
		System.out.println(x.contains("h"));  //check if string contains a substring
		System.out.println(x.indexOf("l"));  //index of first occurrence
		System.out.println(x.lastIndexOf("l"));  //index of last occurrence
		System.out.println(x.strip());  //remove beginning and ending white spaces
		System.out.println(x.substring(3));  //substring starting from specified index
		//can also be specified the last index of substring
		int c = x.indexOf("e");
		int b = x.lastIndexOf("l");
		System.out.println(x.substring(c,b+1));
	}
	*/
	
	/*
	{
		Scanner x = new Scanner(System.in);
		System.out.println("Enter your name: ");
		String name = x.nextLine();
		x.close();
		if(name.toLowerCase().equals("andrei")) {  //if statement
			System.out.println("This is your PC");
		}
		else if(name.toLowerCase().equals("bob")) {
			System.out.println("You are my guest");
		}
		else {
			System.out.println("Not allowed");
		}
		
		switch(name)  //switch statement
		{
		case "dog":
			System.out.println("You have to be a cat");
			break;
		case "cat":
			System.out.println("Meow");
			break;
		default:
			System.out.println("Not a good thing");
		}
		
		int x = 10;
		int y = (x>10) ? 1 : 0;  //ternary operator
		System.out.println(y);
	}
	*/
	
	/*
	{
		int i = 0;
		while(i < 10) {  //while loop
			System.out.println(i + " ");
			i++;
		}
		
		do {  //do while loop
			System.out.println("Iterating...");
		} while(i<0);
		
		for(i=0; i<10; i++) {  //for loop
			System.out.println(i);
		}
		
		for(i=0; i<10; i++) {  //nested for loop
			for(int j=0; j<i; j++) {
				System.out.print("+");
			}
			System.out.println();
		}
		
		for(i=0; i<6; i++) {  //printing  a pyramid
			for(int j=i; j<6; j++) {
				System.out.print(" ");
			}
			for(int j=0; j<=i*2; j++) {
				System.out.print("*");
			}
			System.out.println();
		}
	}
	*/
	
	/*
	{
		//int[] grades = new int[10];  //declaring an array - allocating memory
		int[] grades = {1, 2, 3, 4, 0, -1};  //declaring array literal
		grades[0] = 10;
		System.out.println(Arrays.toString(grades));  //printing items of array
		Arrays.sort(grades);  //sort array
		Arrays.parallelSort(grades);  //sorting method used for bigger arrays
		System.out.println(Arrays.binarySearch(grades, 0));  //searching for a speicified element
		//array must be sorted to use the method
		for(int i=0; i<grades.length-1; i++) {  //sorting array descending order
			for(int j=i; j<grades.length; j++) {
				if(grades[i]<grades[j]) {
					int temp = grades[i];
					grades[i] = grades[j];
					grades[j] = temp;
				}
			}
		}
		int[] grades_copy = grades;
		System.out.println(Arrays.equals(grades, grades_copy));  //compare arrays
		Arrays.fill(grades_copy, 0);  //fill an array with a specified value
	}
	*/
	
	/*
	{
		int[][] arr = new int[10][10];  //2D array
		for(int i=0; i<9; i++) Arrays.fill(arr[i], 6);  //fill a 2D array
		System.out.println(Arrays.deepToString(arr));
		int[][] jagged_arr = new int[3][];  //jagged array
		jagged_arr[0] = new int[2];
		jagged_arr[1] = new int[] {1, 2, 3};
		jagged_arr[2] = new int[] {1, 2, 0, 8, 9};
		System.out.println(Arrays.deepToString(jagged_arr));
	}
	*/
	
	/*
	{
		List<Integer> grades = new ArrayList<Integer>();  //ArrayList
		grades.add(4);  //append elements
		grades.add(0, 6);  //add element at specified index
		//shifts the ArrayList to the right
		System.out.println(grades.get(0));  //get a value
		System.out.println(grades.indexOf(4));  //index of a specified element
		System.out.println(grades.contains(8));  //check if it contains a specified element
		System.out.println(grades.isEmpty());  //check if it is empty
		System.out.println(grades.remove(1));  //remove an element specifying the index
		grades.clear();  //clear
		int[] arr = {1, 2, 3, 4};
		List<Integer> list = Arrays.asList(1, 2, 3, 4);  //creating list with known values
		System.out.println(list);
		System.out.println(Arrays.toString(list.toArray()));  //proper way to printing a list
		System.out.println(list.size());  //number of elements in list
		for(int i=0; i<list.size(); i++) {
			list.set(i, list.get(i)*list.get(i));
			System.out.println(list.get(i));
		}
		for(int item : list) {  //foreach
			System.out.print(item + " ");
		}
	}
	*/
	
	/*
	{
		List<List<Integer>> list = new ArrayList<List<Integer>>();  //2D list
		list.add(Arrays.asList(1, 2, 3));
		list.add(Arrays.asList(1, 0));
		list.add(Arrays.asList(1, 2, 3, 7, 8));
		for(List<Integer> sub_list : list) {  //foreach for 2D lists
			for(int nr : sub_list) {
				System.out.print(nr + " ");
			}
			System.out.println();
		}
		
		//program to convert a list to an array
		int[] arr = new int[list.get(0).size()];
		int it = 0;
		for(int item : list.get(0)) {
			arr[it] = item;
			it++;
		}
		Collections.sort(list.get(0));  //sort a list
		Collections.reverse(list.get(list.size() - 1));
		
		for(int i : list.get(2)) {
			System.out.print(i + " ");
		}
	}
	*/
	
	/*
	{
		User me = new User();
		me.setFirstName("Andrew");  //assigning name using the setter
		me.lastName = "Bob";
		System.out.println(me.getFirstName());  //print name using the getter
		me.Welcoming();  //instance method call
		User you = new User(true);  //using overloaded constructor
		you.setFirstName("Dan");
		you.lastName = "Carl";
		List<User> users = Arrays.asList(me, you);
		User.printUsers(users);  //static method call
		System.out.println(me.hashCode() == you.hashCode());
	}
	*/
	
	
	{
		Student me = new Student();
		me.setFirstName("Sarah");  //Student object using method inherited from User
		me.sayHello();
		User you = new Teacher("Bob");  //polymorphism
		System.out.println(you.getFirstName());
		me.sayHello();
		me.status = me.status.offline;  //enum
		System.out.println("The user " + me.getFirstName() + " is " + me.status);
	}
}
