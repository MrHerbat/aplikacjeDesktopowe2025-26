#include <iostream>

using namespace std;

struct Uczen{
    string imie;
    int wzrost;
    Uczen *nastepny;
    Uczen *poprzedni;
};

int main()
{
    Uczen *glowa = NULL;
    Uczen *nowy;

    char c;
    do{
        try{
            nowy = new Uczen();
        }catch(bad_alloc){
            cout<<"Brakuje miejsca w liscie"<<endl;
            break;
        }
        cout<<"Podaj imie ucznia: ";
        cin>>nowy->imie;
        cout<<"Podaj wzrost ucznia (w cm): ";
        cin>>nowy->wzrost;

        if(glowa==NULL){
            nowy->nastepny=NULL;
            nowy->poprzedni=NULL;
            glowa=nowy;
        }else{
            Uczen *temp = glowa;
            while(temp->nastepny!=NULL){
                temp=temp->nastepny;
            }
            temp->nastepny=nowy;
            nowy->poprzedni=temp;
        }

        cout<<"Czy chcesz dodac nastepnego ucznia? - t/n  ";
        cin>>c;
    }while(c!='n');

    Uczen *temp = glowa;
    while(temp!=NULL){
        cout<<temp->imie<<" | "<<temp->wzrost<<"cm"<<endl;
        temp=temp->nastepny;
    }
    cout<<endl;

    temp=nowy;
    while(temp!=NULL){
        cout<<temp->imie<<" | "<<temp->wzrost<<"cm"<<endl;
        temp=temp->poprzedni;
    }


    return 0;
}
