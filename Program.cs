internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("THIS PROGRAM CALCULATES THE STUDENT AVERAGAE GRADE.");
        Console.WriteLine();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter number of Grade: ");
        int gradeNumber;

        while (!int.TryParse(Console.ReadLine(), out gradeNumber) || gradeNumber <= 0)
        {
            Console.Write("invalid input: please enter the right number");
        }

        double sum = 0;

        for (int i = 1; i <= gradeNumber; i++)
        {
            double grade;

            Console.Write("enter grade number " + i + ":" + " ");

            while (!double.TryParse(Console.ReadLine(), out grade) || grade <= 0)
            {
                Console.Write("invalid input: please enter the right number ");
            }
            sum += grade;
        }

        Console.WriteLine(name + "'s " + "average grade is: " + (sum / gradeNumber).ToString("F7"));

    }
}
