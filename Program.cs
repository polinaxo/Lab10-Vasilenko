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

int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++) {
    points[i] += 5;
}

foreach (int point in points) {
    Console.WriteLine(point);
}