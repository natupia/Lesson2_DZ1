// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputInt(string message) 
{
    Console.Write(message + " > ");                   
    string inputValue = Console.ReadLine();           
    int result = Convert.ToInt32(inputValue);         
    return result;                                    
}
bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)                 
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");  
    return false;
}

int number = InputInt ("Введите трехзначне число");
if (ValidateNumberRank3(number))
{
    int Rank1 = number %100;
    int Rank2 = Rank1/10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {Rank2} ");
}