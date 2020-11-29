using NUnit.Framework;
using System;
//using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void second_test()
        {
            Console.WriteLine("Class 2: Testing 1");

        }

        [Test]
        public void second_test_test()
        {
            Console.WriteLine("Class 2: Testing 1");
        }
    }
}