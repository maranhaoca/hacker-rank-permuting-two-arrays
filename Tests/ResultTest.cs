using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var A = new List<int>(){0, 1};
        var B = new List<int>(){0, 2};
        var k = 1;

        var expected = "YES";

        var actual = Result.twoArrays(k, A, B);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var A = new List<int>(){2, 1, 3};
        var B = new List<int>(){7, 8, 9};
        var k = 10;

        var expected = "YES";

        var actual = Result.twoArrays(k, A, B);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var A = new List<int>(){1, 2, 2, 1};
        var B = new List<int>(){3, 3, 3, 4};
        var k = 5;

        var expected = "NO";

        var actual = Result.twoArrays(k, A, B);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var A = new List<int>(){1, 2, 2, 1};
        var B = new List<int>(){3, 3, 3, 4};
        var k = 5;

        var expected = "NO";

        var actual = Result.twoArrays(k, A, B);

        Assert.Equal(expected, actual);
    }
}