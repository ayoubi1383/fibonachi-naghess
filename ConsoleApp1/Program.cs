
int number1 = 0;
int number2 = 1;

Console.WriteLine("chandomin donbale ro mikhi ?");
int an = Convert.ToInt32(Console.ReadLine());

for(int x=0; x< an; x=x+2)
{
    number1 = number1 + number2;
    Console.Write(number1);
    Console.Write(",");

    number2 = number2 + number1;
    Console.Write(number2);
    Console.Write(",");
}





