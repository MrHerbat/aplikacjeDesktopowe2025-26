#include <iostream>

using namespace std;

struct Przedmiot{
    string nazwa;
    float cena;
    Przedmiot *next;
};

Przedmiot *usunZNazwa(Przedmiot *glowa,string nazwaPrzedmiotu)
{
    Przedmiot *temp = glowa;
    Przedmiot *poprzedni = glowa;
    temp=glowa;
    while(temp!=NULL)
    {
        if(temp->nazwa==nazwaPrzedmiotu){
            if(temp==glowa){
                glowa=temp->next;
                poprzedni=glowa;
            }else{
                poprzedni->next=temp->next;
            }
            delete temp;
        }else{
            poprzedni=temp;
            temp=temp->next;
        }
    }
    return glowa;
}
Przedmiot *usunZCena(Przedmiot *glowa,int cenaPrzedmiotu)
{
    Przedmiot *temp = glowa;
    Przedmiot *poprzedni = glowa;
    temp=glowa;
    while(temp!=NULL)
    {
        if(temp->cena==cenaPrzedmiotu){
            if(temp==glowa){
                glowa=temp->next;
                poprzedni=glowa;
            }else{
                poprzedni->next=temp->next;
            }
            delete temp;
        }else{
            poprzedni=temp;
            temp=temp->next;
        }
    }
    return glowa;
}

int main()
{
    Przedmiot *head = NULL;
    Przedmiot *tail = NULL;
    Przedmiot *nowy;

    char c;
    do{
        try{
            nowy = new Przedmiot();
        }catch(bad_alloc){
            cout<<"Nie ma juz miejsca na nastepny element"<<endl;
            break;
        }
        cout<<"Podaj nazwe przedmiotu: ";
        cin>>nowy->nazwa;
        cout<<"Podaj cene przedmiotu: ";
        cin>>nowy->cena;

        if(head == NULL){
            head=nowy;
            tail=nowy;
        }else{
            tail->next=nowy;
            tail=nowy;
        }

        cout<<"Czy chcesz dodac nowy element do listy? - t/n  ";
        cin>>c;
    }while(c!='n');

    Przedmiot *temp;
    temp=head;
    while(temp!=NULL){
        cout<<temp->nazwa<<" | "<<temp->cena<<"zl"<<endl;
        temp=temp->next;
    }

    cout<<endl;

    head = usunZNazwa(head,"krzeslo");
    temp=head;
    while(temp!=NULL){
        cout<<temp->nazwa<<" | "<<temp->cena<<"zl"<<endl;
        temp=temp->next;
    }

    return 0;
}
