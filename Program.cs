using DataAccess;

static void PrintAmountWithColor(decimal amount)
{
    Console.ForegroundColor = amount < 0 ? ConsoleColor.Red : ConsoleColor.Green;
    System.Console.WriteLine(amount);
    Console.ResetColor();
}

var fr = new FileRepository();

DateTime today = DateTime.Now;

// Print the total savings for the current month in the format Month : Savings
System.Console.WriteLine($"Today's Date: {today.ToString()}");
System.Console.WriteLine("Total Savings for...");
System.Console.Write($"{today.ToString("MMMM")} :\t\t $ ");

decimal currentMonthAmount = fr.GetMonthlyTotalAmount(today.Month);
PrintAmountWithColor(currentMonthAmount);

// Print the total savings for the last month
System.Console.Write($"{today.AddMonths(-1).ToString("MMMM")} :\t\t $ ");
decimal lastMonthAmount = fr.GetMonthlyTotalAmount(today.AddMonths(-1).Month);
PrintAmountWithColor(lastMonthAmount);

// Print the total savings for the last 6 months
System.Console.Write("Last 6 months :\t $ ");
decimal lastSixMonthsAmount = fr.GetSumOfLastGivenMonths(6);
PrintAmountWithColor(lastSixMonthsAmount);

// Print the total savings for the entire csv file
decimal totalSavingsAmount = fr.GetTotalAmount();
System.Console.Write("All time :\t $ ");
PrintAmountWithColor(totalSavingsAmount);

