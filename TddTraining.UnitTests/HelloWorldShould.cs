using System;
using Xunit;
using FluentAssertions;

namespace TddTraining.UnitTests
{
    public class HelloWorldShould
    {
        [Fact]
        public void SayHelloWorld()
        {
            var text = HelloWorld.Say();

            text.Should().Be("Hello World");
        }
    }
}
