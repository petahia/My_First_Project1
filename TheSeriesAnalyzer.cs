namespace My_First_Project;

public class TheSeriesAnalyzer
{
    static List<int> listInput = new List<int>();
    static void Main(string[] args)
    {
        DisplayMenu(char.Parse(Console.ReadLine()));
    }

    static void Input()
    {
        Console.WriteLine("Enter numbers separated by Commas:");
        string input  = Console.ReadLine();
        
        listInput = input.Split(',').Select(int.Parse).ToList();
    }

    static bool ValidateInput(List<int> series)
    {
        bool valid =  true;
        foreach (var num in series)
        {
            if (num < 0)
            {
                valid = false;
            }
        }
        if (series.Count < 3)
        {
            valid = false;
        }
        return valid;
    }
    
    
    static char DisplayMenu(char select)
    {
        Console.WriteLine(
            "b. Display the series in the order it was entered." +
            "c. Display the series in the reversed order it was entered." +
            "d. Display the series in sorted order (from low to high)." +
            "e. Display the Max value of the series." +
            "f. Display the Min value of the series." +
            "g. Display the Average of the series." +
            "h. Display the Number of elements in the series." +
            "i. Display the Sum of the series." +
            "j. Exit.");
        char c = select;
        int ascii = (int)c;
        if (ascii >= 97 && ascii <= 102)
        {
            do
            {
                switch (select)
                {
                    case 'a':
                        Input();
                        break;
                    case 'b':
                        OrderEntered(listInput);
                        break;
                    case 'c':
                        OrderReversed(listInput);
                        break;
                    case 'd':
                        OrderSorted(listInput);
                        break;
                    case 'e':
                        Max(listInput);
                        break;
                    case 'f':
                        Min(listInput);
                        break;
                    case 'g':
                        Average(listInput);
                        break;
                    case 'h':
                        Length(listInput);
                        break;
                    case 'i':
                        Sum(listInput);
                        break;
                    case 'j':
                        Input();
                        break;
                    default:
                        break;
                } 
            } while (case != "j");
            
        }
        else
        {
            Console.WriteLine("invalid menu selection");
        }
        return c;
    }
    static List<int> OrderEntered(List<int> series)
    {
        return series;
    }
    static List<int> OrderReversed(List<int> series)
    {
        List<int> revesed = new List<int>();

        for (int i = series.Count - 1; i >= 0; i--)
        {
            revesed.Add(series[i]);
        }

        return revesed;
    }
    static List<int> OrderSorted(List<int> series)
    {
        List<int> sorted = new List<int>();
        return sorted;
    }
    static int Max(List<int> series)
    {
        int max = series[0];
        for (int i = 1; i < series.Count; i++)
        {
            for (int j = i; j < series.Count; j++)
            {
                if (series[j] > max)
                {
                    max = series[j];
                }
            }
        }
        return max;
    }
    static int Min(List<int> series)
    {
        int min = series[0];
        for (int i = 1; i < series.Count; i++)
        {
            for (int j = i; j < series.Count; j++)
            {
                if (series[j] < min)
                {
                    min = series[j];
                }
            }
        }
        return min;
    }
    static double Average(List<int> series)
    {
        return Sum(series) / series.Count;
    }
    static int Length(List<int> series)
    {
        return series.Count;
    }
    static int Sum(List<int> series)
    {
        int summary = 0;
        foreach (int number in series)
        {
            summary += number;
        }
        return summary;
    }
}