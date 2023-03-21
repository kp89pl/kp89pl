string name = "Ewa";
char sex = 'K';
int age = 33;

if (sex == 'M' && age > 18)
{
    Console.WriteLine("Kobieta poniżej lat 30");
}

if (age < 33 && sex == 'K')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else if  (name == "Ewa" && age < 40)
{
    Console.WriteLine("Ewa lat 33");
}
