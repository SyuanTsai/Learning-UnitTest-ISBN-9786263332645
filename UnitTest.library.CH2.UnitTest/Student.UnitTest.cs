using UnitTest.Library.CH2;

namespace UnitTest.library.CH2.UnitTest;

public class StudentUnitTest
{

    [Test]
    public void FullNameTest()
    {
        var student = new Student("John", "Doe");
        Assert.That(student.FullName, Is.EqualTo("John Doe"));
    }
}
