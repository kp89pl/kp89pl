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
