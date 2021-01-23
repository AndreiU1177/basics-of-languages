from math import *
name = "Andrei"  # string
age = 16  # number (int)
sex_M = True  # boolean

'''print("Hello " + name)
print("You are " + str(age) + " y/o")    #str used to transform int into string
print("I put\nspace")      #\n - new line
print(name.upper())    #converts the string "name" to be full uppercased
                       #can also be used other functions su ch as lower()
print(type())       #prints the type of a specified variable                       
print(name.isupper())     #checks if the string is full uppercased
print(name.upper().isupper())     #can also be used multiple functions
print(len(name))      #prints how many characters the string has
print(name[0])      #prints the first character of the string (the count starts from 0)
print(name.index("e"))     #it gives you the location of the first "e" in the string
print(name.index("re"))    #can also put a string from the string, it will print the position where the sub-string starts
print(name.replace("ndr", "rd"))    #replaces a part of the string, or the entire
print(age*age)
print(abs(age))      #absolute value of the int
print(pow(3, 3))     #raise a number to a power
print(max(10, 69))    #prints the higher number, can also be used min
print(round(4.6))     #prints the nearest integer to a number
print(floor(8.9))      #erases the decimals
print(ceil(8.9))     #erases the decimals and adds 1 to the int
print(sqrt(16))    #prints the square root of a number

x=input()      #get input from an user
print("Your name is not: " + x)

powers_of_2 = [1, 2, 4, 8, 16, 32, 64]      #list (vector)
powers_of_3 = [1, 3, 9, 27, 81]
print(powers_of_2[0])     #prints an element by his index
print(powers_of_2[-1])     #can also be used  negative numbers in order to start counting from the end
print(powers_of_2[1:4])     #prints elements from the first index, to the second, not included the last
powers_of_2.extend(powers_of_3)    #extends an array with another one
powers_of_2.append(128)       #extends an array with only one object
powers_of_2.insert(1, "Nothing")     #inserts a new element in the specified index
powers_of_2.remove(1)     #removes a specified element
powers_of_2.clear()     #clears the entire array
powers_of_2.pop()     #removes the last element
print(powers_of_2.index(16))      #prints the index of a specified element
print(powers_of_2.count(1))     #prints how many times a specified element is in an array
powers_of_2.sort()      #sorts the array from the lowest to highest number
                        #can also sort strings in alphabetical order
powers_of_2.reverse()     #the opposite of sort()
natural_numbers = powers_of_2.copy()      #copies an array
prime_numbers = (2, 3, 5, 7)     #tuple
    #tuple - very similar to lists, but you can't modify the values inside
pair_of_prime_numbers = [(2,3), (5, 7), (11, 13)]    #list of tuples
print(prime_numbers[1])
print(pair_of_prime_numbers[2])
def main(x):        #call a function
    print("Hello " + x))     #in order to write in the function, the text has to be indented
    #working with parameters is optimal
main("George")
def halfof_a_number(a):
    a = a/2      # / - used for float
    return a     # // - used for integers
print(halfof_a_number(1025))
x=halfof_a_number(1025)      #alternative
print(x)
a=True
b=True
if a and b:
    print("The booleans are both true")
elif a and not(b):
    print("a is true and b is false")
if not(a) and b:
    print("a is false and b is true")
if a or b:
    print("At least one is true")
else:
    print("None of them are true")
def biggest(n1, n2, n3):
    if n1>=n2 and n1>=n3:
        print(str(n1) + " is the biggest")
    elif n2>=n1 and n2>=n3:
        print(str(n2) + " is the biggest")
    else:
        print(str(n3) + " is the biggest")
print("Enter 2 numbers: ")
a = float(input())  # used float in order to transform the input into a number
b = float(input())
c = input("operation: ")
if c == "+":
    print(a + b)
if c == "-":
    print(a - b)
if c == "/":
    print(a / b)
if c == "x":
    print(a * b)
month_conversions = {      #dictionary, used for saving different types of data
    "Jan": "January",
    "Feb": "February",
    "Mar": "March"
}
print(month_conversions["Jan"])
print(month_conversions.get("Jan"))     #alternative
print(month_conversions.get("Hfg", "Not in the dictionary"))     #specify if a Key is not in the dictionary

a = 1
s = 0
while a <= 100:
    s = s + a
    a += 1
print(s)
num = float(input("Enter a number: "))
s = 0
while num > 0:
    s = s + num % 10
    num //= 10
print("The sum of the number's digits is: " + str(s))
for i in range(1, 11, 2):      #start, end, step
    print(i)
print(2 ** 3)  # 2 raised to the 3rd power
def raise_to_power(num, pow):  # function that prints the power of a number
    num_copy = num
    for i in range(1, p):
        num = num_copy * num
    return num
print(raise_to_power(10, 4))
digits = [                  #2D list(matrice)
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
    [0]
]
print(digits[1][1])
for row in digits:
    for col in row:
        print(col)
def translate(phrase):        #transform all the vowels of a string into z
    translation = ""
    for letter in phrase:
        if letter.lower() in "aieou":       #if it is a capital, we'll transform into a lower-case
            if letter.isupper():
                translation = translation + "Z"
            else:
                translation = translation + "z"
        else:
            translation = translation + letter
    return translation
print(translate(input("Enter a name: ")))
buckets = [[0 for col in range(5)] for row in range(10)]    #create a 2D list of 0
            #prints something if the user's input is not an integer
try:
    result = 6/1        #certain error: "ZeroDivisionError"
    num = int(input("Enter a number: "))     #certain error if you enter a any other type of data, except integer: "ValueError"
    print(num)
    print(result)
except ZeroDivisionError:         #you can personalize except, for any certain error
    print("You cannot divide a number by 0!")
except ValueError:
    print("You cannot enter any type of data but integer!")
name_file = open("names.txt", "r")         # "r" stands for read
#once you read a line, it can't be read again
print(name_file.readable())      #checks if the file is readable
print(name_file.read())        #reads the entire file
print(name_file.read(2))       #reads the first 2 chars of the file
print(name_file.readline())       #reads a line
print(name_file.readlines()[0])      #print a line according to index
for name in name_file.readlines():      #for loop used to print all the lines
    print(name)
name_file = open("names.txt", "a")     # "a" stands for append
name_file.write("\nDavid")      #write in the end of the file
results = open("results.txt", "w")      # "w" stands for write
results.write("1\n10")      #creates a file and writes in it
#you can also overwrite a file
name_file.close()       #essential
print(my_functions.number_of_digits(10123))     #uses an external file as a module
#there are lots of modules preinstalled, but also on the internet'''
'''from Student import Question     #in order to use a class
questions = [
    "How old is Andrei?\na)14\nb)15\nc)16\n\n",
    "What's the middle name of Andrei?\na)David\nb)None\nc)Cristian\n"
]
answers = [
    Question(questions[0], "c"),
    Question(questions[1], "b")
]
def quiz(answers):
    final = 0
    for x in answers:
        answer = input(x.q)
        if answer == x.a:
            final += 1
    print("Congrats, you got " + str(final) + " points from a maximum of " + str(len(questions)) + ".")
quiz(answers)
from Student import Student

Student1 = Student("Oscar", "Accounting", 3.1)
Student2 = Student("Nick", "Business", 3.8)
print(Student1.on_honor_roll())
print(Student2.on_honor_roll())'''




