/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int Digit3 (int number){
   while (number > 999){
      number = number / 10;
   }
   return number % 10;
}

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N > 99) {
   Console.WriteLine($"Третья цифра числа = {Digit3(N)}");
}
else {
   Console.WriteLine("Третьей цифры нет");
}

/*       Решение через индекс строки

Console.Write("Введите число : ");
String N = Console.ReadLine();

if (N.Length > 3){
   Console.WriteLine($"Третья цифра числа = {N[2]}");
}
else{
   Console.WriteLine($"Третьей цифры нет");
}
*/
