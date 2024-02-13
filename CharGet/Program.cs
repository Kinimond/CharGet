namespace CharGet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] temp;
            string charInput;

            Console.WriteLine("Skriv et ord!");

            input = Console.ReadLine();
            Console.WriteLine("Dit valgte ord er: " + input);

            Console.WriteLine("Vælg hvilket nummer bogstav du vil udskrive");
            charInput = Console.ReadLine();

            temp = charInput.Split(',');

            for (int i = 0; i < input.Length; i++) {
            
            Console.WriteLine(input[int.Parse(temp[i]) -1]);

        }
            Console.ReadLine();
        }
    }
}