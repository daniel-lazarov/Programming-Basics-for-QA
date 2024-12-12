namespace ConsoleAppSummator.Tests;

public class AppSummatorTests
{

  
    [Test]
    public void Test1()
    {
        //Arrange
        int[] arrayOfNum = new int[] { 1, 2, 3 };

        //Act
        int SumOfArray = Summator.Sum(arrayOfNum);

        //Assert


        //int sumOfArray = Summator.Sum(new int[] { 1, 2, 3 });

        //Assert.AreEqual(6, sumOfArray);

        Assert.That(SumOfArray, Is.EqualTo(6));

    }
}
