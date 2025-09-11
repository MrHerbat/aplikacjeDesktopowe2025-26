#include <iostream>

using namespace std;

struct Osoba{
    string nazwisko;
    int wiek;
    Osoba *next;
};

int main()
{
    char odp;
    Osoba *head = NULL;
    Osoba *nowy;

    do{
        try{
            nowy = new Osoba;
        }catch(bad_alloc){
            cout<<"Nie ma juz miejsca na nastepny element";
            break;
        }
        cout<<"Podaj nazwisko: ";
        cin>>nowy->nazwisko;
        cout<<"Podaj wiek: ";
        cin>>nowy->wiek;
        nowy->next=head;
        head=nowy;

        cout<<"Czy chcesz dodac nastepna osobe? t/n"<<endl;
        cin>>odp;
    }while(odp!='n');
    Osoba *temp;
    temp=head;
    while(temp!=NULL){
        cout<<temp->nazwisko<<" | "<<temp->wiek<<endl;
        temp=temp->next;
    }
    return 0;
}
