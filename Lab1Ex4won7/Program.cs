/*Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/

int num;
Console.WriteLine("Introduce un numar: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("+");
}

else if (num < 0)
{
    Console.WriteLine("-");
}

else if (num == 0)
{
    Console.WriteLine("0");
}

   Console.ReadLine();