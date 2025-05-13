namespace My_First_Project;

public class TheSeriesAnalyzer
{
    static void Main(string[] args)
    {
        DisplayMenu(char.Parse(Console.ReadLine()));
    }

    static List<int> Input(string input)
    {
        return input.Split(',').Select(int.Parse).ToList();
    }

    static string ValidateInput(string input)
    {
        
    }
    
    
    static char DisplayMenu(char select)
    {
        Console.WriteLine(
            "a. Input a Series." +
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
            switch (select)
            {
                case 'a':
                    Input();
                    break;
                case 'b':
                    OrderEntered();
                    break;
                case 'c':
                    OrderReversed();
                    break;
                case 'd':
                    OrderSorted();
                    break;
                case 'e':
                    Max();
                    break;
                case 'f':
                    Min();
                    break;
                case 'g':
                    Average();
                    break;
                case 'h':
                    Length();
                    break;
                case 'i':
                    Sum();
                    break;
                case 'j':
                    Input();
                    break;
                default:
                    break;
            }
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