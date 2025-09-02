#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{
    srand(time(NULL));
    int x;
    x = 8;
    int *w;
    w = &x;
    cout<<"wartosc x - "<<x<<endl;
    cout<<"adres a/samo w - "<<w<<endl;
    cout<<"wartosc adresu/wartosc w - "<<*w<<endl;
    cout<<"==========="<<endl;
    *w=15;
    cout<<"wartosc w - "<<*w<<endl;
    cout<<"wartosc x - "<<x<<endl;
    cout<<"========="<<endl;

    int a;
    int b;
    a = 20;
    b = 14;
    int *w1;
    int *w2;
    w1=&a;
    w2=&b;
    int s = *w1+*w2;
    cout<<s<<endl;

    int tab[10];
    for(int i = 0;i<10;i++){
        tab[i]=rand()+10;
    }
}
