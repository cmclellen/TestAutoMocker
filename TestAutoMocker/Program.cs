using Moq;
using StructureMap.AutoMocking.Moq;
using System;

namespace TestAutoMocker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ARRANGE
            var autoMocker = new MoqAutoMocker<SomeService>();
            var sut = autoMocker.ClassUnderTest;
            Mock.Get(autoMocker.Get<ISomeRepository>()).Setup(m => m.GetSomeString()).Returns("HELLO THERE");

            // ACT
            var actual = sut.GetSomeString();

            // ASSERT
            Console.WriteLine(string.Equals(actual, "HELLO THERE"));
            Console.ReadLine();
        }
    }
}