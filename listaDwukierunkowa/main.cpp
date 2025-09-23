#include <iostream>

using namespace std;

struct Student{
    string name;
    int height;
    Student *next;
    Student *prev;
};

void writeHigherStudents(Student *head)
{
    Student *temp = head;
    Student *tempNext;
    Student *tempPrev;
    while(temp!=NULL){
        tempNext = temp->next;
        tempPrev = temp->prev;

        if(tempPrev==NULL && tempNext!=NULL){
            if(temp->height>tempNext->height){
                cout<<temp->name<<" | "<<temp->height<<"cm"<<endl;
            }
        }else if(tempPrev!=NULL && tempNext==NULL){
            if(temp->height>tempPrev->height){
                cout<<temp->name<<" | "<<temp->height<<"cm"<<endl;
            }
        }else if(tempPrev!=NULL && tempNext!=NULL){
            if(temp->height > tempPrev->height &&
            temp->height > tempNext->height){
                cout<<temp->name<<" | "<<temp->height<<"cm"<<endl;
            }
        }
        temp=temp->next;
    }
}

int main()
{
    Student *head = NULL;
    Student *newStudent;

    char c;
    do{
        try{
            newStudent = new Student();
        }catch(bad_alloc){
            cout<<"Brakuje miejsca w liscie"<<endl;
            break;
        }
        cout<<"Podaj imie ucznia: ";
        cin>>newStudent->name;
        cout<<"Podaj wzrost ucznia (w cm): ";
        cin>>newStudent->height;

        if(head==NULL){
            newStudent->next=NULL;
            newStudent->prev=NULL;
            head=newStudent;
        }else{
            Student *temp = head;
            while(temp->next!=NULL){
                temp=temp->next;
            }
            temp->next=newStudent;
            newStudent->prev=temp;
        }

        cout<<"Czy chcesz dodac nastepnego ucznia? - t/n  ";
        cin>>c;
    }while(c!='n');
    cout<<endl;

    Student *temp = head;
    while(temp!=NULL){
        cout<<temp->name<<" | "<<temp->height<<"cm"<<endl;
        temp=temp->next;
    }
    cout<<endl;
    writeHigherStudents(head);




    return 0;
}
