Console.Clear();
const int max_points_exam = 20;
int points_reached = 0;
int points_max_reachable = 0;
int points_reached_first_exam = 0;
int points_reached_second_exam = 0;
double grade_percentage = 0;

Console.Write("Did you participate in the first exam?[Yes/No]: ");
string answer_first_exam = Console.ReadLine()!;
Console.Write("Did you participate in the second exam?[Yes/No]: ");
string answer_second_exam = Console.ReadLine()!;

if (answer_first_exam == "yes" || answer_first_exam == "Yes"){
    points_max_reachable += max_points_exam;
    Console.Write("How many points did you reach[out of 20]? ");
    points_reached_first_exam += int.Parse(Console.ReadLine()!);
}
if (answer_second_exam == "yes" || answer_second_exam == "Yes"){
    points_max_reachable += max_points_exam;
    Console.Write("How many points did you reach[out of 20]? ");
    points_reached_second_exam += int.Parse(Console.ReadLine()!);
}

points_reached += points_reached_first_exam + points_reached_second_exam;
grade_percentage += 100d * points_reached / points_max_reachable;

switch (grade_percentage){
    case < 50:
        Console.WriteLine("I am sorry but you got a 5 in this subject");
    break;
    case >= 50 and < 63:
        Console.WriteLine("You got a 4 in this subject.");
    break;
    case >= 63 and < 76:
        Console.WriteLine("Good Job you got a 3 in this subject.");
    break;
    case >= 76 and < 89:
        Console.WriteLine("Congratulations you got a 2 in this subject");
    break;
    case >= 89:
        Console.WriteLine("Your amazing you got a 1 in this subject");
    break;
}

