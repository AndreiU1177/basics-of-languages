/*
alert("WELCOME");       //pops a message
document.getElementById("button").onlick = function(){        //run a function when button is clicked
    document.getElementById("confirm").innerHTML = "Order placed. Check email.";    //rewrites confirm
    document.getElementById("button").style.display = "none";    //erases the button
}
*/

/*
var username = prompt();
alert("Hello " + username);
console.log(username);    //output in console

//declaring a variable INSIDE a function makes it local
//declaring a variable OUTSIDE a function makes it global
*/

/*
{
    //block
    let x = 10;
    const y = 20;   //constant variable, cannot be reassigned

    //let and const are block scoped variables, CAN'T BE ACCESSED FROM WINDOW OBJECT

    x = 7;
    console.log(x);
}
*/

/*
{
    let x = 5;
    let y = "10";

    console.log(x+parseInt(y));   //parseInt - converts a data type to int
}
*/

/*
//creating an object
let person = {
    name: "Andrei",      //property: "-"
    age: 16,
    job: "student",
    fun: function(){    //functions are also properties
        console.log("WOW");
        console.log(this.name);
    }
}

let newArray = [1, 2, 4];    //array object
let hello = new Date();    //date object

//primitive data types = string, number, boolean, undefined, null
*/

/*
{
    let myName = "Andrei";    //primitive
    let yourName = new String("Alin")     //object

    myName = myName.toUpperCase();    
    //when we use a function to a primitive, it automatically converts it
    //to an object, runs the function and then it's converted back to a primitive
}
*/

/*
{
    let x = 9043287443;
    console.log(Number.isSafeInteger(x));   //check if a number is in the safe limit
    //there is only 1 type of data for numbers: Number;
    x++;    //increment by 1
    x--;    //decrement by 1
}
*/

/*
{
    let x = prompt("Enter your number: ");
    
    console.log("Decimal: " + x);
    console.log("Binary: " + Number.parseInt(x, 2));
    console.log("Octal: " + Number.parseInt(x, 8));
    console.log("Hex: " + Number.parseInt(x, 16));

    let y = Number(prompt("Enter your number: "));
    
    console.log(y + " in Decimal: " + y);
    console.log(y + " in Binary: " + y.toString(2));
    console.log(y + " in Octal: " + y.toString(8));
    console.log(y + " in Hex: " + y.toString(16));
}
*/

/*
{
    let x = 10.1982471;
    console.log(x.toFixed(3));   //prints a number with fixed decimal points
    console.log(x.valueOf());   //prints the primitive value of a variable
    console.log(typeof(x));    //prints the primitive type of data of a variable

    var abs = Math.abs(-36);  //36
    var goUp = Math.ceil(.0001);  //1
    var goDown = Math.floor(.9999);  //0
    var isPositive = Math.sign(-21);  //-1
    var truncation = Math.trunc(4.9999);  //4
}
*/

/*
{
    let myName = "Andreir";
    console.log(`My name is ${myName}!`);  //another way to print using a template
    console.log(myName.length);  //prints the number of chars in a string
    console.log(myName.charAt(2));  //alternative way to print a char by its index
    console.log(myName.concat(" is great!"))  //append to the end of a string(alt to +)
    console.log(myName.includes("rei"));  //search a syntax in a string
        //second paramater, which indicates the start index (optional)
    console.log(myName.indexOf("r"));  //prints the index of the searched char
        //second paramater, which indicates the start index (optional)
    console.log(myName.lastIndexOf("r"));  //starts the search from the right
    console.log(myName.substring(4, 6));  //prints a substring
    console.log(myName.substr(1, 3));  //second paramater is the lenght of the string
    console.log(myName.trim());  //removes the beggining and ending white spaces
    console.log(myName.split(" "));  //split a string using certain separator
}
*/

/*
{
    let position = {  //object
        a: 1,
        b: 2
    }
    
    let not_copy_position = position;  //NOT A COPY
    not_copy_position.a = 10;  //modifications will be done also in the core object(position)
    console.log(position);
}
*/

/*
{
    var name = prompt("Enter your name");  //if statement
    var age = prompt("Enter your age");
    if (name === "Andrei"){
        alert("Welcome, " + name);
    }
    else {
        alert("You are not the owner!");
    }
    if (age>12 && age<65){
        alert("You are allowed!");
    }
}
*/

/*
{
    let name = prompt("What is your name?")  //switch statement

    switch(name){
        case "Andrei":
            console.log("Less go!");
            break;
        case "Dan":
            console.log("Not allowed!");
            break;
        default:
            console.log("Just leave");
            break;
    }
}
*/

/*
{
    let i = 0;
    while (i<10){      //while loop
        console.log(i);
        i++;
    }

    let x = 0;
    do {
        console.log(x);  //do while loop
        x++;
    } while(x<10);

    for (let a=0; a<10; a++){  //for loop
        console.log(a);
    }
}
*/

/*
{
    let myString = "Andooreoooi";
    for (let i = 0; i < myString.length; i++){
        if (myString[i] === 'o'){
            continue;  //skips the iteration
        }
        console.log(myString[i]);
    }
}
*/

/*
{
    let ages = [14, 15, 16];  //array
    let grades = [  //multidimensional array
        [6, 9, 0],
        [10, 9, 7],
        [5, 8, 9]
    ]
    console.log(grades[0][1]);

    ages.length = 10;  //change the size of array
    for (let i = 0; i < ages.length; i++){
        console.log(ages[i]);
    }
}
*/

/*
{
    let grades = [];

    while (true){
        let input = prompt("Insert a number. Type QUIT to exit.")
        if (input.toLowerCase() === "quit"){  //sentinel value
            break;
        }
        grades.push(Number(input));
    }
    console.log(grades);
}
*/

/*
{
    let grades = [1, 2, 3]
    grades.push(4);  //add to the end
    grades.unshift(0);  //add to the beginning
    grades.pop();  //removes the last element
    grades.shift();  //removes the first element
    grades.splice(0, 2);  //deletes elements
    //it can also replace them using a third argument
    let gradesB = [8, 7, 10];
    grades.concat(gradesB);  //same as push,
        // but it doesn't modify the original array
    grades.indexOf(3);  //get the index of an element
    grades.slice(0, 3);  //get a substring
}
*/

/*
{  //forEach for 1-line array
    let grades = [12, 17, 19, 22, 1];

    grades.forEach(function(item, i){  //forEach method
        console.log(item);
    });
    //1st arg = element from array
    //2nd arg = index of the specific element
    //it skips the undefined elements
}
*/

/*
{  //forEach for multidimensional arrays
    let numbers = [
        [1, 3, 9],
        [0, 1, 8],
        [9, 8, 5, 3, 2]
];

    numbers.forEach(function(item){
        item.forEach(function(elem){
            console.log(elem);
        })
        console.log("-----")
    });
}
*/

/*
{
    let grades = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ]

    outerLoop: for (let i = 0; i<grades.length; i++){  //label
        for (let k = 0; k<grades[i].length; k++){
            console.log(grades[i][k]);
            if (grades[i][k] === 4){
                console.log("Value found!")
                //break outerLoop;
                continue outerLoop;
            }
            console.log("Number printed!");
        }
        console.log("~~~~~~~")
    }

}
*/

/*
{  //date object
    let myDate = new Date();  //month arg 0 based!!
    console.log(myDate);
    console.log(Date.now());  //date in miliseconds
    //milisecond 0 = Jan 1 1970
}
*/

/*
{
    let myDate = new Date(2020, 3, 6);
    console.log(myDate.getFullYear());  //get month
    console.log(myDate.getMonth());  //get month
    console.log(myDate.getDate());  //get day
    myDate.setFullYear(2019);  //set year
    //lots of methods similar
    console.log(myDate.getTimezoneOffset());
}
*/

/*
{
    function pow(x, y){  //function declaration
        let total = 1;
        for (let i = 1; i <= y; i++){
            total *= x;
        }
        return total;
    }
    console.log(pow(3, 3));

    Func1 = function(){  //function expression
        console.log("HEY");
    }
    //functions work like objects
}
*/

/*
{
    pow.calculated = {};  //object
    function pow(x, y){
        result = x + '^' + y;
        let total = 1;
        for (let i = 0; i < y; i++){
            total *= x;
        }
        pow.calculated[result] = total;  
        //add a value to an object attribute
        return total;
    }
    pow(10, 1);
    pow(10, 2);
    pow(10, 3);
    pow(10, 4);
    console.log(pow.calculated);
}
*/

/*
{
    function sum(x = 2, y = 2){  //default param
        return x + y;
    }

    function sum(x, y, ...extra){  //rest param
        let sum2 = 0;
        for (let i = 0; i < extra.length; i++){
            sum2 += extra[i];
        }
        return x + y + sum2;
    }
}
*/

/*
{
    let me = {
        name: "Caleb",
        outputme: function(){
            console.log(this);
            console.log(this.name);
        }
    };
    //this keyword refers to the object it belongs to
    me.outputme();

    function doStuff(input, input2){
        console.log(input, input2);
        console.log(this);
    }

    doStuff.call("HELLO", 1, 2);
    //changes the this point(object it belongs to)
}
*/

/*
{
    let arrowSum = (a, b) => a+b;
    console.log(arrowSum(10,20));
    document.getElementById("button").onclick = () => {console.log("You clicked it!")};
    //event listener
    //arrow function
    //multiple lines of code require {}
}
*/

/*
{
    try{  //try catch block
        kokpa();
    }
    catch(e){
        console.log(e);
    }
}
*/

/*
{
    function User(name, age, grade){  //constructor function
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    let me = new User("Andrei", 16, 10);
    let you = new User("David", 15, 9);

    //similar to constructor function is:
    function creatingObj(name, age){  //factory function
        let person = {
            name: name,
            age: age
        };

        return person;
    }
    console.log(creatingObj("Caleb", 44));
}
*/

/*
{
    let user = {
        active: true,
        sayHello: function(){
            return this.name + " says hi!";
        }
    };

    let student = {
        name: "David",
        grade: 10
    };

    let teacher = {
        name: "Alex",
        teaching: ["math", "science"]
    };


    Object.setPrototypeOf(student, user);  //inheritance
    Object.setPrototypeOf(teacher, user);
    //teacher may use user's properties
    console.log(teacher.active);
    console.log(student.active);

    //how to look for a property of an object
    console.log("active" in teacher);  //it also counts the prototype
    console.log(teacher.hasOwnProperty("active"));
    
}
*/

/*
{
    //object constructor

    function User(){
        this.active = true;
    }

    function Student(name, age){
        this.name = name;
        this.age = age;
    }

    Student.prototype = new User();  //set prototype

    let s1 = new Student("David", 15);
    console.log(s1.active);

    //instanceof - check if an object inherits from another object
    console.log(s1 instanceof Student);
    //works only with constructor functions
}
*/

/*
{
    let b = document.getElementById("button1");
    b.onclick = function(){
        b.style.backgroundColor = "red";
    }
}
*/

/*
{  //DOM children
    let a = document.childNodes[1].childNodes[2]
    .childNodes[3];
    console.log(a);

    //using event listeners

    let mybut = document.getElementById("button1");
    mybut.onmouseenter = function(){
        console.log("CHECKED!");
        mybut.innerHTML = "BOOYA";
    }

    mybut.onmouseleave = function(){
        mybut.innerHTML = "Confirm";
    }
}
*/


{
    //working with attributes

    let myinput = document.getElementById("input");
    console.log(myinput.attributes);
    console.log(myinput.getAttribute("value"));

    //adding nodes

    let mybut = document.getElementById("button2");

    mybut.onclick = function(){
        let node = document.createElement("li");
        console.log(node);

        node.appendChild(document.createTextNode(
            document.getElementById("input").value));  //append the value from the input

        let mylist = document.getElementById("lista");
        mylist.appendChild(node);
    }
}