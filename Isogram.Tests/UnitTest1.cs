using System;
using Xunit;
using ClassLibrary1;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("eleven");
            var expected = false;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("subdermatoglyphic");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("thumbscrew-japingly");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("six-year-old");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test6()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("isogram");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test7()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("don mak");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test8()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.Isogramcheck("Alphabet");
            var expected = true;
            Assert.Equal(expected, actual);
        }


    }
}