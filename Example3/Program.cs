internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number for the day of the week:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        void DayWeek (int dayNumber){
          if (dayNumber == 6 || dayNumber == 7){
            Console.WriteLine("(This day is day off) -> Yes");
          }
          else if (dayNumber < 1 || dayNumber > 7){
            Console.WriteLine("It's not a day of the week");
          }
          else Console.WriteLine("(This day is not a day off) -> No"); 
        }
        
        DayWeek(dayNumber);

    }
}