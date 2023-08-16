namespace gettingstarted;

public class LinqMediumSolutions
{
    public int CountVowels(string text)
    {
        var q = from i in text.ToCharArray() where "aeiou".Contains(i) select i;
        return q.Count();
    }

    public List<int> GetNumbersInRange(List<int> numbers, int startIndex, int endIndex)
    {
        var q = from i in numbers
            where (numbers.IndexOf(i) >= startIndex && numbers.IndexOf(i) <= endIndex)
            select i;
        return q.ToList();
    }

    public int GetSumOfSquares(List<int> numbers)
    {
        var q = from i in numbers select i * i;
        return q.Sum();
    }

    public List<string> GetWordsLongerThanN(List<string> words, int n)
    {
        var q = from i in words where i.Length > n select i;
        return q.ToList();
    }

    public List<string> GetDistinctWords(string text)
    {
        var q = text.Split(' ').ToList();
        return q.Distinct().ToList();
    }

    public bool AnyWordStartsWithA(List<string> words)
    {
        var q = from i in words where i.ToLower()[0].Equals('a') select i;
        return q.Any();
    }

    public List<int> GetNumbersDivisibleBy3Or5(List<int> numbers)
    {
        var q = from i in numbers where i % 3 == 0 || i % 5 == 0 select i;
        return q.ToList();
    }

    public List<string> GetWordsSortedByLength(string text)
    {
        var strings = text.Split(' ').ToList();
        return strings.OrderBy(s => s.Length).ToList();
    }

    public List<int> GetSquaredNumbersSorted(List<int> numbers)
    {
        var q = from i in numbers select i * i;
        return q.Order().ToList();
    }

    public int CountUniqueCharacters(string text)
    {
        return text.Distinct().Count();
    }

    public Dictionary<string, int> GetWordFrequencies(string text)
    {
        var dict = new Dictionary<string, int>();
        var words = text.Split(' ').ToList();
        var uniques = GetDistinctWords(text);
        foreach (var unique in uniques)
        {
            {
                var q = from w in words where w.Equals(unique) select w;
                dict.Add(unique, q.Count());
            }
        }

        return dict;
    }

    public string GetLongestString(List<string> strings)
    {
        return strings.OrderBy(s => s.Length).Reverse().ToList()[0];
    }
}