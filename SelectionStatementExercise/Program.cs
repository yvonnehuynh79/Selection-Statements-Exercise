namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 5);
            Console.WriteLine("try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("Perfect!");

            }
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            
                   

            
            
        }
    }


}
