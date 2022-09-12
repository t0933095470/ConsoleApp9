// Swithc case structure

int i;
Console.WriteLine("Please input an integer number");
i = Convert.ToInt32(Console.ReadLine());
switch (i%2)
{
    case 0:
        Console.WriteLine("This is an even number.");
        break;
    case 1: Console.WriteLine("This is not an even number.");
        break;
    default: Console.WriteLine("Please input again");
        break;
}

