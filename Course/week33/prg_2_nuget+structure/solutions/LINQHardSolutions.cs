namespace gettingstarted;


public class HardLinqSolutions : IHardLinqExercises
{
    public List<string>GetAnagrams(string word, List<string> words)
    {
        var sortedWord = string.Concat(word.OrderBy(c => c));
        var anagrams = new List<string>();

        foreach (var isMaybeAnAnagram in words)
        {
            var sorted = string.Concat(isMaybeAnAnagram.OrderBy(c => c));
            if (sorted == sortedWord) //then it is definitely, because anagrams contain same elements in different order
            {
                anagrams.Add(isMaybeAnAnagram);
            }
        }

        return anagrams;
    }

    class Streak
    {
        public List<int> numbers = new List<int>();
    }

    public List<int> GetLongestIncreasingSequence(List<int> numbers)
    {
        var longestSeq = new List<int>();
        var currentSeq = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (currentSeq.Count == 0 || numbers[i] > currentSeq.Last())
            {
                currentSeq.Add(numbers[i]);
            }
            else
            {
                if (currentSeq.Count > longestSeq.Count)
                {
                    longestSeq = new List<int>(currentSeq);
                }
                currentSeq.Clear();
                currentSeq.Add(numbers[i]);
            }
        }
        if (currentSeq.Count > longestSeq.Count)
        {
            longestSeq = currentSeq;
        }

        return longestSeq;
    }
    
}

