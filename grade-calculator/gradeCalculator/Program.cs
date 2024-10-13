namespace gradeCalculator
{
    /*
     * Jacob Jablon
     * IGME 201-01 Interac Des & Alg Prob Sol III
     * Due 10/13/2024
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring and initializing variables
            string nameOfStudent = "Jacob Jablon";
            int[] numbers = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = 0;

            // welcoming the user
            Console.WriteLine("Welcome " + nameOfStudent);
            Console.WriteLine("Here are your grades:");

            // iteratinng through array and writing to the console based on the grade received
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

                if (numbers[i] >= 90 && numbers[i] <= 100) {
                    Console.WriteLine("This grade is an A!");
                    if (numbers[i] == 100) // if a perfeect score
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                } else if (numbers[i] >= 80 && numbers[i] < 90) {
                    Console.WriteLine("This grade is a B.");
                } else if (numbers[i] >= 70 && numbers[i] < 80) {
                    Console.WriteLine("This grade is a C.");
                } else if (numbers[i] >= 65 && numbers[i] < 70) {
                    Console.WriteLine("This grade is a D.");
                } else if (numbers[i] >= 0 && numbers[i] < 65) {
                    Console.WriteLine("This grade is a F.");
                } else { // if grade is not in the 0-100 range
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }

            // calculating the average
            for (int i = 0; i < numbers.Length; i++) {
                average += numbers[i];
            }
            average = average / numbers.Length;
            Console.WriteLine("Your final calculated average is: " + average);

            // ending the program with a final console log
            Console.WriteLine("We have displayed all grades for " + nameOfStudent);
        }
    }
}
