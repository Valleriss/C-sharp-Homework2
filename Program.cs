/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(CheckWeekEnd(N));


string CheckWeekEnd(int NumDay){
    if(NumDay == 6 || NumDay == 7){
        return "Выходной день";
    }
    else if(NumDay > 7){
        return "В неделе 7 дней!";
    }
    else{
        return "Рабочий день";
    }
}
