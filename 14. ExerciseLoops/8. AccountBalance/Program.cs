double balance = 0;

do
{
    string currentInput = Console.ReadLine();

    if (currentInput.ToLower() != "end")
    {
        if (double.TryParse(currentInput, out double amount))
        {
            if (amount > 0)
            {
                Console.WriteLine($"Increase: {amount:F2}");
                //string text = "Increase: ";
                balance = balance + amount;
            }
            else if (amount < 0)
            {
                amount = Math.Abs(amount);
                Console.WriteLine($"Decrease: {amount:F2}");
                //string text = "Increase: ";
                balance = balance - Math.Abs(amount);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number or 'End' to finish.");
        }
    }
    else
    {
        Console.WriteLine($"Balance: {balance:F2}");
        break;
    }

} while (true);