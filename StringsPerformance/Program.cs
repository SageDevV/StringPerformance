using System.Text;

public class Program
{
    private const int REPETITIONS = 1000;

    public static void StringTest()
    {
        string result = String.Empty;
        for (int i = 0; i < REPETITIONS; i++)
        {
            result += "#";
        }
    }
    public static void StringBuilderTest()
    {
        StringBuilder result = new(REPETITIONS);
        for (int i = 0; i < REPETITIONS; i++)
        {
            result.Append("#");
        }
    }
    static void Main(String[] args)
    {
        //StringTest();
        StringBuilderTest();

        Console.WriteLine("Press enter to exit...");
        Console.Read();
    }
}