#include "Classtuff.h"
#include <iostream>
using namespace std;

Classtuff::Classtuff(int a, int b)     ///constructor
: regVar(a), constVar(b)    ///member initializor
{
}

void Classtuff::hala(){         ///function inside a class
    cout << regVar << " and " << constVar << endl;
}

void Classtuff::hala2() const{
    cout << "i am a constant function" << endl;       ///constant function
}
