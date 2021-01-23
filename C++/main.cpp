#include <iostream>
#include <string>      ///in order to work with strings
#include <cstdlib>     ///in order to generate random numbers
#include <ctime>       ///in order to manipulate date and time information
#include <fstream>     ///in order to work with files
#include "Classtuff.h"
using namespace std;
/*class acc{
    public:  ///access specifier
        acc(string a){     ///constructor - useful in setting values to variables
            setName(a);
        }
        void setName(string x){  ///method
            name = x;
        }
        string getName(){
            return name;
        }
    private:         ///it is optimal to specify variables in private
        string name;
};
int main()
{
    acc user1("Andrei");
    cout<<"Hello "<<user1.getName()<<endl;

}

int main()
{
    int age = 16;

    switch(age){       ///compact multiple if statements
        case 4:
            cout << "You good" << endl;
            break;          ///used to not continuing going through the rest switch - optional
        case 89:
            cout << "You should be dead" <<  endl;
            break;
        default:
            cout << "Congrats! You achieved nothing!" << endl;
    }
}


int main()
{
    srand(time(0));      ///in order to change the seed
    cout << rand() << endl;         ///print a random number
    cout << rand()%10 << endl;          ///print a number in a range
}


void printNumber(int x){
    cout << "This is an integer: " << x << endl;
}
                                                        ///function overloading
void printNumber(float x){
    cout << "This is a float: " << x << endl;
}

int main()
{
    int a = 13;
    float b = 3.14;

    printNumber(a);      ///due to overloading, the program can automaticaly detect the right function to use
    printNumber(b);
}


int factorial(int x){
    if (x==1)
        return 1;
    else
        return x*factorial(x-1);         ///recursion
}

int main()
{
    cout << factorial(5);
}


void printArray(int theArray[], int Array_size){

    for (int x = 0; x<Array_size; x++){
        cout << theArray[x] << endl;
    }
}

int main()
{
    int lol[6] = {26, 25, 1, 8, 90, 55};

    printArray(lol, 6);
}


int main()
{
    int ball = 3;

    cout << &ball << endl;      ///prints the memory address

    int *ballPointer;     ///pointer that takes as value a memory address

    ballPointer = &ball;      ///doesn't have to be accessed with *
    cout << ballPointer << endl;
}



void passByReference(int *x);
void passByValue(int x);

int main()
{
    int a = 10;
    int b = 10;

    passByValue(a);
    passByReference(&b);

    cout << "a is: " << a << endl;
    cout << "b is: " << b << endl;
}

void passByValue(int x){
    x = 99;
}

void passByReference(int *x){
    *x = 88;
}


int main()
{
    char c;
    double arr[10];
    cout << sizeof(c) << endl;   ///prints the size of a variable in bytes
    cout << sizeof(arr);
}


int main()
{
    int a[10];
    int *a1 = &a[0];
    int *a2 = &a[1];
    int *a3 = &a[2];

    cout << a1 << endl;
    cout << a2 << endl;
    cout << a3 << endl;

    a1 += 2;             ///it changed the address that the pointer was pointing to
    cout << a1 << endl;         ///it DID NOT change the address
}


int main()
{
    int x = 5;
    x = 10;
    cout << x << endl;

    const int y = 5;          ///a constant variable value cannot be changed
    cout << y << endl;

    const Classtuff constObj;    ///creating a constant object
    constObj.hala2();

    ///in a class, constant object require constant functions
}


class Soka{
    public:
        Soka(){
            sokaVar = 16;
        }
    private:
        int sokaVar;

    friend void sokaFriend(Soka & sfo);    ///friend function - it can be accessed inside of a class, although it isn't part of the class
};

void sokaFriend(Soka & sfo){
    sfo.sokaVar = 99;
    cout << sfo.sokaVar << endl;
}

int main()
{
    Soka sokaObj;
    sokaFriend(sokaObj);
}



class first{
    public:
        void printNum(int x){
            cout << "Your number is: " << x << endl;
        }
};

class second: public first{     ///inheritance

};

int main(){
    second bobo;
    bobo.printNum(10);         ///function from first class used on a second class object
}



class Enemy{
    public:
        virtual void attack(int attackPower){}    ///virtual function ensures that the correct function is called for an object, regardless of the type of reference (or pointer) used for function call

};

class Ninja: public Enemy{
    public:
        void attack(int attackPower){
            cout << "ninja chop -" << attackPower << endl;
        }

};

class Monster: public Enemy{
    public:
        void attack(int attackPower){
            cout << "monster eats you -" << attackPower << endl;
        }

};

int main()
{
    Ninja Sakura;
    Monster Murlock;
    Enemy *enemy1 = &Sakura;
    Enemy *enemy2 = &Murlock;
    enemy1->attack(10);
    enemy2->attack(20);
}



template <class general>         ///function template, building a generic type of data

general addNums(general a, general b){
    return a+b;
}

int main()
{
    cout << addNums(8.7, 9.1);
}


template <class A, class B>
A smaller(A a, B b){       ///the return type will be one of the two generics
    return (a<b?a:b);
}

int main()
{
    cout << smaller(90.7, 89);
}


template <class T>
class okay{       ///template class
    T first, second;
    public:
        okay(T a, T b) {first = a; second = b;}
        T bigger();
};
template <class T>      ///it has to be written again before creating functions linked to the class
T okay<T>::bigger(){
    return (first>second?first:second);
}

template<>              ///template specialization
class okay<char>{
    public:
        okay(char x){cout << x << " is a character";}

};

int main()
{
    okay <int> obj(12, 21);        ///inside the <> you have to pass the type of data that the template will substitute
    cout << obj.bigger() << "\n";
    okay <char> obj2('q');    ///if we specify a data type that is specific to the specialized template, it will run on that template
}


int main()
{
    try{               ///try except
        int momsAge = 39;
        int sonsAge = 34;

        if (sonsAge > momsAge)
            throw 99;
    }
    catch(int x)
        {cout << "son can't be older than the mom. ERROR NUMBER: " << x << endl;}
}


int main()
{
    //ofstream myFile("printing.txt");       ///for writing

   //myFile << "YA";
    //myFile.close();

    ifstream myFile("printing.txt");      ///for reading
    int num;

    while(myFile >> num)
        cout << num << ' ';
}
*/

int main()
{
    string x;
    getline(cin, x);     ///gets input from user and stores in x until we pass to a new line
    cout << x << endl;
    string y;
    y.assign(x);   ///another method to copy strings
    cout << y << endl;
    cout << y.at(0) << endl;    ///prints a character from string, according to the index
    cout << y.length() << endl;       ///prints the length of a string
    cout << y.substr(3, 5) << endl;       ///prints a substring, takes as arguments the start and the lenght of the substring
    string z("zebras");
    z.swap(y);       ///swap strings
    cout << y << ' ' << z;
    cout << z.find('l') << endl;    ///prints the location of a character or substring
    cout << z.find('l') << endl;    ///prints the location of a character or substring, but starts from the end
    cout << z.erase(4) << endl;    ///erases part of the string, beginning with the argument
    z.replace(1, 4, "yoyoyo");    ///first arg - the beginning      2nd arg - lenght of substring
    z.insert(0, "problem");      ///adds a string, beginning from the first arg
}
