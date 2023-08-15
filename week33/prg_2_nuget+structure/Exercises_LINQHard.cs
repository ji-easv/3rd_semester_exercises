/*
The exercises in here are regarded as being "extra", since they are vastly
more difficult than the previous two.

Task: Implement all the methods. All of them can be completed using LINQ.
Basic conditionals and loops can also do the job.
Success criteria: All tests passing.
Learing objective: Being able to write harder algorithms.
Additional help: I put guided solutions in the ./Solutions directory.
*/

using NUnit.Framework;

namespace gettingstarted;

public class HardLinqExercises : IHardLinqExercises
{
    public List<string> GetAnagrams(string word, List<string> words)
    {
        var letters = word
            .Split()
            .Order()
            .ToList();

        throw new NotImplementedException();
    }

    public List<int> GetLongestIncreasingSequence(List<int> numbers)
    {
        throw new NotImplementedException();
    }
}

public interface IHardLinqExercises
{
    List<string> GetAnagrams(string word, List<string> words);
    List<int> GetLongestIncreasingSequence(List<int> numbers);
}

[TestFixture]
public class HardLinqTests
{
    private IHardLinqExercises _exercises;

    [SetUp]
    public void Setup()
    {
        _exercises = new HardLinqExercises();
    }

    [Test]
    public void TestGetAnagrams()
    {
        // Arrange
        string word = "post";
        var words = new List<string> { "stop", "tops", "spot", "posts", "hello", "world" };

        // Act
        var result = _exercises.GetAnagrams(word, words);

        // Assert
        Assert.That(result, Is.EquivalentTo(new List<string> { "stop", "tops", "spot" }));
    }

    [Test]
    public void TestGetLongestIncreasingSequence()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 1, 2, 3, 4, 1, 2 };

        // Act
        var result = _exercises.GetLongestIncreasingSequence(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 3, 4 }));
    }
}