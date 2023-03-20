// liczby calkowite
using System.ComponentModel.Design;

int myAge = 34;
int myMartaAge = 30;
int myDaughterAge = 2;
int newAge = myAge + myMartaAge + myDaughterAge;
Console.WriteLine(newAge);

// zmienne tekstowe
string dad = "Jakub";
string daughter = "Liwia";
string mom = "Marta";
string Family = dad + daughter + mom + newAge;
Console.WriteLine(Family);
string dog = "Rex";
string cat = "Salsa";
string teddy = "Bogdan";
string zoo = dog + cat + teddy;
Console.WriteLine(zoo);

// liczby całkowite
int myBest = 22;
int herBest = 10;
int livBest = 5;
int ourBest = myBest + herBest + livBest;
Console.WriteLine(ourBest);
float myNumber = float.MaxValue;
Console.WriteLine(myNumber);

//zmienne logiczne
bool isActive = false;
var isOk = 6 > 5;
Console.WriteLine(isOk);

var number1 = 5;
var number2 = 10;

if (number1 > number2) ;
{
    Console.WriteLine("Jestem tutaj linia 41");
}







string name = "Ewa";
char sex = 'K';
int age = 33;

if (sex == 'K' && age > 18)
{
    Console.WriteLine("Kobieta poniżej lat 30");
}

else if (age >= 33 && sex == 'K')
{
    Console.WriteLine("Ewa lat 33");
}

else if  (name == "Ewa" && age < 40)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
