using FluentAssertions;
using NUnit.Framework;

namespace testing;

public class RandomClass
{
    public string ReturnPhrase()
    {
        return "Happy Coding!";
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void TestTwoAndTwo()
    {
        var expected = 4;
        var actual = 2 + 2;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestReturnPhrase()
    {
        // Arrange
        var expected = "Happy Coding!";
        var randomClass = new RandomClass();

        // Act
        var actual = randomClass.ReturnPhrase();

        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    // Fluent Assertions
    [Test]
    public void TestValidEmail()
    {
        string actual = "bo@bo.com";
        actual.Should().Contain("@");
    }

    [Test]
    public void FortyTwoTwentyFour()
    {
        int number = 24;
        number.Should().NotBe(42);
    }

    [Test]
    public void StringStartsWith()
    {
        var word = "Ahoy!";
        word.Should().StartWith("A");
    }

    [Test]
    public void DivisionByZero()
    {
        var x = new RandomClass();
        Action act = () => x.Divide(1, 0);

        act.Should().Throw<DivideByZeroException>();
    }
}