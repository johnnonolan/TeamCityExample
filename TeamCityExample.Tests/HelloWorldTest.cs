using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TeamCityExample.Tests
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void TestSayHi()
        {
            var helloWorld = new HelloWorld();
            Assert.That("Hello: world",Is.EqualTo(helloWorld.SayHi("world")));
        }

    }
}
