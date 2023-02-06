using NUnit.Framework;
using SourceProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.IsTrue(result);
        }
    }
}
