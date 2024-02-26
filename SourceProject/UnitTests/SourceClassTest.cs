using NUnit.Framework;
using SourceProject;

namespace UnitTests
{
    public class SourceClassTest
    {
        private SourceClass _sourceClass;

        [SetUp]
        public void Setup()
        {
            _sourceClass = new SourceClass();
        }

        [Test]
        [Category("UnitTest_P1")]
        public void IsPositiveNumber_ReturnTrue()
        {
            var result = _sourceClass.IsPositiveNumber(1);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
