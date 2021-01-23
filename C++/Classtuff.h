#ifndef CLASSTUFF_H
#define CLASSTUFF_H


class Classtuff
{
    public:                 ///you have to prototype the functions that you've created in cpp file
        Classtuff(int a, int b);
        void hala();
        void hala2() const;
    protected:

    private:
        int regVar;
        const int constVar;
};

#endif // CLASSTUFF_H
