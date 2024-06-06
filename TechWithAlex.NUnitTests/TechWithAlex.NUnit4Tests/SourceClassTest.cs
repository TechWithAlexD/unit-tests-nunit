using NUnit.Framework;
using TechWithAlex.SourceProject;

namespace TechWithAlex.Nunit4Tests;

public class SourceClassTest
{  
    private SourceClass? _sourceClass;

    [SetUp]
    public void Setup()
    {
        _sourceClass = new SourceClass();
    }

    [TestCase(1)]
    [Category("Test_P1")]
    public void IsPositiveNumber_ReturnTrue(int val)
    {
        var result = _sourceClass?.IsPositiveNumber(val);

        Assert.That(result, Is.True);
    }
}
