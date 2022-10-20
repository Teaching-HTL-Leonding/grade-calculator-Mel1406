Console.Clear();
const int max_points = 20;
int points_reached = 0;
int points_reached_with_all_homework = 0;
int points_max_reachable = 20;
int points_reached_first_exam = 0;
int points_reached_second_exam = 0;
int points_reached_homework = 0;
int points_reached_oral_exam = 0;
double grade_percentage = 0;
double grade_percentage_with_all_homework = 0;
int grade = 0;
int grade_with_all_homework = 0;

Console.Write("Did you participate in the first exam?[Yes/No]: ");
string answer_first_exam = Console.ReadLine()!;
if (answer_first_exam == "yes" || answer_first_exam == "Yes"){
    points_max_reachable += max_points;
    Console.Write("How many points did you reach[out of 20]? ");
    points_reached_first_exam += int.Parse(Console.ReadLine()!);
}

Console.Write("Did you participate in the second exam?[Yes/No]: ");
string answer_second_exam = Console.ReadLine()!;
if (answer_second_exam == "yes" || answer_second_exam == "Yes"){
    points_max_reachable += max_points;
    Console.Write("How many points did you reach[out of 20]? ");
    points_reached_second_exam += int.Parse(Console.ReadLine()!);
}

Console.Write("How many points did you get through homework? ");
points_reached_homework = int.Parse(Console.ReadLine()!);

Console.Write("Did you participate in an oral exam?[Yes/No]: ");
string answer_oral_exam = Console.ReadLine()!;
if (answer_oral_exam == "yes" || answer_oral_exam == "Yes"){
    points_max_reachable += max_points;
    Console.Write("How many points did you reach[out of 20]? ");
    points_reached_oral_exam = int.Parse(Console.ReadLine()!);
}

points_reached += points_reached_first_exam + points_reached_second_exam + points_reached_homework + points_reached_oral_exam;
grade_percentage += 100d * points_reached / points_max_reachable;

switch (grade_percentage){
    case < 50:
        grade += 5;
        Console.WriteLine("I am sorry but you got a 5 in this subject");
    break;
    case >= 50 and < 63:
        grade += 4;
        Console.WriteLine("You got a 4 in this subject.");
    break;
    case >= 63 and < 76:
        grade += 3;
        Console.WriteLine("Good Job you got a 3 in this subject.");
    break;
    case >= 76 and < 89:
        grade += 2;
        Console.WriteLine("Congratulations you got a 2 in this subject");
    break;
    case >= 89:
        grade += 1;
        Console.WriteLine("Your amazing you got a 1 in this subject");
    break;
}
points_reached_with_all_homework = points_reached_first_exam + points_reached_second_exam + max_points + points_reached_oral_exam;
grade_percentage_with_all_homework = 100d * points_reached_with_all_homework / points_max_reachable;
switch (grade_percentage_with_all_homework){
    case < 50:
        grade_with_all_homework += 5;
    break;
    case >= 50 and < 63:
        grade_with_all_homework += 4;
    break;
    case >= 63 and < 76:
        grade_with_all_homework += 3;
    break;
    case >= 76 and < 89:
        grade_with_all_homework += 2;
    break;
    case >= 89:
        grade_with_all_homework += 1; 
    break;
}
if (grade != grade_with_all_homework){
    Console.WriteLine("If you did all your homework you would have gotten a {0} instead of a {1}.", grade_with_all_homework, grade);
}
Console.ReadKey(); 