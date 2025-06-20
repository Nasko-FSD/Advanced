int totalStudents = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> allStudents = new Dictionary<string, List<decimal>>();

for (int i = 0; i < totalStudents; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    decimal allGrades = decimal.Parse(input[1]);


    if (! allStudents.ContainsKey(name))
    {
        allStudents.Add(name, new List<decimal>());
    }
    allStudents[name].Add(allGrades);
}

foreach (var student in allStudents)
{
    decimal totalSum = student.Value.Sum();
    int totalGrades = student.Value.Count();
    decimal averageGrades = totalSum / totalGrades;
    string gradesFormatted = string.Join(" ", student.Value.Select(g => $"{g:F2}"));

    Console.WriteLine($"{student.Key} -> {gradesFormatted} (avg: {averageGrades:F2})");
}