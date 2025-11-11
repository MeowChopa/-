#include <iostream>
#include <cmath>

using namespace std;

int type_of(int x){

    do{
    cout<<"Введите значение переменной: ";
    cin>>x;

    if(cin.fail() || x <= 0){
        cout<<"Введено некорректное значение"<<endl;
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(),'\n');
    }
    else{ break;}
    }while(true);
    return x;
}

int main(){

    int massive[5];
    int* link = massive;

    for(int j = 0; j < (sizeof(massive)/sizeof(int)); j++){
       *(link+j) = type_of(*(link+j));
    }

    for(int i = 0; i < (sizeof(massive)/sizeof(int)); i++){
        cout<<*(link+i)<<endl;
    }

    return 0;
}
