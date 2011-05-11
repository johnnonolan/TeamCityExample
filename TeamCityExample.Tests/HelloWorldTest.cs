using System;
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

        [Test]
        public void TestBogOff()
        {
            var helloWorld = new HelloWorld();

            Assert.That("Hello: world", Is.EqualTo(helloWorld.GetStuffed("world")));
        }
         
         
    }
}  
