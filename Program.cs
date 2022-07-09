// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void DelThirdNumber (int number){
    string arr = number.ToString();
    if (arr.Length < 3) Console.WriteLine("третьей цифры нет");
    else Console.WriteLine($"{number} : {arr[2]}");
}
Console.WriteLine("------- Вывод результата 13 задаче");
DelThirdNumber(123);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void WeDay (int day){
    if (day <= 7 ) {
        if (day%7 == 0 || day%6 == 0){
            Console.WriteLine("Указан выходной день");        
        }
        else Console.WriteLine("Рабочий день");
    }
    else Console.WriteLine("В неделе не может быть больше 7 дней");
}
Console.WriteLine("------- Вывод результата 15 задаче");
WeDay(5);
