using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Add_Valid_Poggemeyer()
        {
            Assert.AreEqual(7, Program.Add("4", "3"));
            Assert.AreEqual(17, Program.Add("8", "9"));
            Assert.AreEqual(27, Program.Add("9", "18"));
        }

        [Test]
        public void Subtract_Valid_Poggemeyer()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-2, Program.Subtract("5", "7"));
        }

        [Test]
        public void Multiply_Valid_Poggemeyer()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("5", "7"));
        }

        [Test]
        public void Divide_Valid_Poggemeyer()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(6, Program.Divide("36", "6"));
            Assert.AreEqual(10, Program.Divide("100", "10")); 
        }

        [Test]
        public void Power_Valid_Poggemeyer()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(78125, Program.Power("5", "7"));
        }
    }
}
