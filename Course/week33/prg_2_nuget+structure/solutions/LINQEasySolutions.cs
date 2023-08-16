namespace gettingstarted;

public class EasyLinqSolutions : IEasyLinqExercises
{
    // Exercise 1: Return all odd numbers from the given list.
    public List<int> GetAllOddNumbers(List<int> numbers)
    {
        var q = from i in numbers where i % 2 != 0 select i;
        return q.ToList();
    }

    // Exercise 2: Return the average of all numbers from the given list.
    public double GetAverage(List<int> numbers)
    {
        return numbers.Average();
    }

    // Exercise 3: Return the first 3 numbers from the given list.
    public List<int> GetFirstThreeNumbers(List<int> numbers)
    {
        return numbers.Slice(0, 3);
    }

    // Exercise 4: Return the last number from the given list.
    public int GetLastNumber(List<int> numbers)
    {
        return numbers.Last();
    }

    // Exercise 5: Return the string "Hello, [name]!" for each name in the given list.
    public List<string> GetHelloMessages(List<string> names)
    {
        var q = from i in names select $"Hello, {i}";
        return q.ToList();
    }

    // Exercise 6: Return the number of elements in the given list.
    public int CountElements(List<int> numbers)
    {
        return numbers.Count;
    }

    // Exercise 7: Return a list of numbers multiplied by 2.
    public List<int> GetDoubledNumbers(List<int> numbers)
    {
        var q = from i in numbers select i * 2;
        return q.ToList();
    }

    // Exercise 8: Return a list of strings converted to uppercase.
    public List<string> ConvertToUpper(List<string> words)
    {
        var q = from i in words select i.ToUpper();
        return q.ToList();
    }

    // Exercise 9: Return true if the given number exists in the list, false otherwise.
    public bool IsNumberInList(List<int> numbers, int number)
    {
        return numbers.Contains(number);
    }

    // Exercise 10: Return a list of distinct numbers from the given list.
    public List<int> GetDistinctNumbers(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }
}