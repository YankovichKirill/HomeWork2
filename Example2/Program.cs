internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int anyNumber = Convert.ToInt32(Console.ReadLine());
        string anyNumberText = Convert.ToString(anyNumber);
        if (anyNumberText.Length > 2){
            Console.WriteLine("Third digit ->" + anyNumberText[2]);
    }
    else {
        Console.WriteLine("-> No third digit");
    }
    }
}       
