// string subject = "Программирование";

// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }

// Console.WriteLine(subject.Length);

// int total = 0;
// int[] grades = { 4, 5, 3, 5, 4 };

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
//     total += grade;
// }

// Console.WriteLine($"Средний балл: {(double)total / grades.Length}");
// Console.WriteLine($"Сумма оценок {total}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students) {
//     Console.WriteLine(student);
//     count++;
// }

// Console.WriteLine($"В массиве {count} учеников");

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++) {
//     points[i] += 5;
// }

// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students) {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }


//Самостоятельные задания А и Б
// int[] numbers = { 1, 2, 3, 4, 5 };
// int sum = 0;

// foreach (int number in numbers) {
//     Console.WriteLine(number);
//     sum += number;
// }

// Console.WriteLine($"Сумма: {sum}");

// string[] days = { "Понедельник", "Вторник", "Среда" };

// foreach (string day in days) {
//     Console.WriteLine($"{day}!");
// }


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 

//Вариант 1
// int[] temp = {1, 2, 3, 4, 5, 6, 7};
// int total = 0;

// foreach (int temper in temp) {
//     total += temper;
// }

// Console.WriteLine($"Средняя температура за неделю: {(double)total / temp.Length}");

//Вариант 9
// int[] numbers = {1, 2, 3, 4, 5, 6, 7};

// for (int i = 0; i < numbers.Length; i++) {
//     numbers[i] += 1;
// }

// foreach (int num in numbers) {
//     Console.WriteLine(num);
// }

string[] names = { "Анна", "Борис", "Вера", "Глеб", "Дарья" };
int[] grades = { 5, 4, 3, 5, 4 };
int sum = 0;
int maxGrade = grades[0];
string topStudent = names[0];
for (int i = 0; i < names.Length; i++) {
    Console.WriteLine($"{names[i]}-{grades[i]}");
    sum += grades[i];
    if (grades[i] > maxGrade) {
        maxGrade = grades[i];
        topStudent = names[i];
    }   
}
double average = (double)sum / names.Length;
Console.WriteLine($"Средний балл: {average}");
Console.WriteLine($"Лучший ученик: {topStudent}");