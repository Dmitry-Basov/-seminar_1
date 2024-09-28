// Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".

Console.WriteLine("Напишите первое целое цисло: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
     Console.WriteLine("Внимание!На ноль делить нельзя!");
}
else if (num1 % num2 == 0 )
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
} 
