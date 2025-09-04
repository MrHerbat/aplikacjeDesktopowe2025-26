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
        tab[i]=(rand()%(100-10))+10;
        cout<<tab[i]<<" ";
    }
    cout<<endl;
    int *w3;
    w3=&tab[0];
    cout<<&w3<<endl;
    for(int i = 0; i<10;i++){
        *(w3+i)=(rand()%(1000-100))+100;
        cout<<*(w3+i)<<" ";
    }
    cout<<endl;
    for(int i = 0;i<10;i++){
        cout<<tab[i]<<" ";
    }
    cout<<endl;
    cout<<"========="<<endl;

    int *dTab = new int[20];
    for(int i = 0; i<20; i++){
        dTab[i]=rand()%10;
        cout<<dTab[i]<<" ";
    }
    cout<<endl;
    delete dTab;
    for(int i = 0; i<20; i++){
        cout<<dTab[i]<<" ";
    }
    cout<<endl;
    cout<<"========="<<endl;
    int **dTab2 = new int*[6];
    for(int i = 0; i<6;i++){
        dTab2[i] = new int[3];
    }
    for(int i=0;i<6;i++){
        for(int j=0;j<3;j++){
            dTab2[i][j]=(rand()%90)+10;
            cout<<dTab2[i][j]<<" ";
        }
        cout<<endl;
    }
}
