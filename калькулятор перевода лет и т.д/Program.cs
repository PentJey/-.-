internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа считает 365 дней в году, а также 30 дней в месяце по умолчанию");
        Console.WriteLine("Выберите что выхотите перевести в минуты\n" +
            "1) Года \n" +
            "2) Месяца \n" +
            "3) Недели \n" +
            "4) Дни \n" +
            "5) Часы");

switch (Convert.ToInt16(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Введите кол-во лет");
                double YearsInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Кол-во минут в годах: {YearsInput * 365 * 24 * 60}");
                break;
            case 2:
                Console.WriteLine("Введите кол-во месяцев");
                double MonthsInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Кол-во минут в месяцах: {MonthsInput * 1440 * 30}");
                break;
            case 3:
                Console.WriteLine("Введите кол-во недель");
                double WeeksInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Кол-во минут в неделях: {WeeksInput * 1440 * 7}");
                break;
            case 4:
                Console.WriteLine("Введите кол-во дней");
                double DaysInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Кол-во минут в днях: {DaysInput * 1440 * 1}");
                break;
            case 5:
                Console.WriteLine("Введите кол-во дней");
                double HoursInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Кол-во минут в часах: {HoursInput * 60 * 1}");
                break;

        }


            


    }
}