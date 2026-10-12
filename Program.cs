// string subject = "Программирование";

// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }

// Console.WriteLine(subject.Length);

int total = 0;
int[] grades = { 4, 5, 3, 5, 4 };

foreach (int grade in grades) {
    Console.WriteLine(grade);
    total += grade;
}

Console.WriteLine($"Средний балл: {(double)total / grades.Length}");
Console.WriteLine($"Сумма оценок {total}");