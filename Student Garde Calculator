namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS PROGRAM CALCULATES THE STUDENTS GRADES");
            Console.WriteLine();
            Console.WriteLine("Enter your Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the number of Grades: ");
            int num = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Enter Grade " + i);
                sum = sum + double.Parse(Console.ReadLine());
            }
            Console.WriteLine(Name + "'s " + "Avarege score is " + sum / num);
        }
    }
}
