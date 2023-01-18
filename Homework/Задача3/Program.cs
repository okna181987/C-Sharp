//По заданному номеру дня недели вывести его название 

Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер дня недели:   ");
string writeDay=Console.ReadLine();
bool result = int.TryParse(writeDay, out int dayNumber);

Console.WriteLine();
if (result == false) Console.WriteLine("Число введено неверно");
else if (0 < dayNumber && dayNumber < 8) Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");
else Console.WriteLine("Дня недели с таким номером не существует");
Console.WriteLine();