namespace MyApp.Tests
{
    using Fixie_experimentation;
    using Shouldly;

    public class CalculatorUnitTests
    {
        public void ShouldAddInts()
        {
            var sut = new Calculator();
            var result = sut.AddInts(a: 1, b: 1);
            result.ShouldBe(expected: 2);
        }

        public void ShouldSubtractInts()
        {
            var sut = new Calculator();
            var result = sut.SubtractInts(a: 1, b: 2);
            result.ShouldBeNegative();
        }

        public void ShouldDivideInts()
        {
            var sut = new Calculator();
            var result = sut.DivideInts(a: 1, b: 1);
            result.ShouldBePositive();
        }

        public void ShouldThrowNotSupportedException()
        {
            var sut = new Calculator();
            _ = Should.Throw<System.NotSupportedException>(() =>
            {
                sut.DivideInts(a: 1, b: 0);
            });
        }

        public void ShouldNotTryToDivideInts()
        {
            var sut = new Calculator();
            var didDivide = sut.TryDivideInts(a: 1, b: 0, result: out _);
            didDivide.ShouldBeFalse();
        }

        public void ShouldReturnZeroWhenNotTryingToDivideInts()
        {
            var sut = new Calculator();
            _ = sut.TryDivideInts(a: 1, b: 0, out int result);
            result.ShouldBe(expected: 0);
        }
    }
}
