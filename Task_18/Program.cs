using System;
using static System.Console;
Clear();

Write("Введите номер четверти: ");
int number = int.Parse(ReadLine());

switch(number)
{
    case 1:
    {
        WriteLine("X, Y");
        break;
    }
    case 2:
    {
        WriteLine("-X, Y");
        break;
    }
    case 3:
    {
        WriteLine("-X, -Y");
        break;
    }
    case 4:
    {
        WriteLine("X, -Y");
        break;
    }
    default:
    {
        WriteLine("Неверная четверть");
        break;
    }

}