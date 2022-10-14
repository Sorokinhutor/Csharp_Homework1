// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее,
// а какое меньшее.

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
Console.WriteLine($"Числа равны");
Environment.Exit( 0 );
}

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
}
else
{
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}");
}

//Задача 4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.
	
int[] nums = new int[3];

Console.WriteLine("Введите три числа");
Console.Write("Первое число: ");
nums[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
nums[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
nums[2] = Convert.ToInt32(Console.ReadLine());

int max = nums[0];

for (int i=0; i < 3; i++)
{
    if (nums[i] > max)
    {
    max = nums[i];
    }
}

Console.WriteLine($"Максимальное число равно {max}");

if (nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2] )
{
Console.WriteLine($"Внимание!!! Есть совпадения введенных чисел");
Environment.Exit( 0 );
}

//Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0){
    Console.WriteLine($"Число {number} четное");
}
else{
    Console.WriteLine($"Число {number} нечетное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("\n" + $"Четные числа от 1 до {number} будут:" + "\n");  
  
for (int i = 2; i <= number; i = i + 2 )
{
 Console.Write(" " + i); 
}

