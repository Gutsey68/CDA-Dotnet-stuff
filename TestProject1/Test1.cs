using CDA_Hello_world;


namespace TestProject1;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestIsArmstrongNumber()
    {
        Assert.IsTrue(Exercices.IsArmstrongNumber(153));
        Assert.IsFalse(Exercices.IsArmstrongNumber(154));
    }
    
    [TestMethod]
    public void TestLongestWord()
    {
        Assert.AreEqual("Hello", Exercices.LongestWord("Hi Hello Hey"));
        Assert.AreEqual("World", Exercices.LongestWord("Hello World !"));
        Assert.AreEqual("Beautiful", Exercices.LongestWord("The Beautiful Day Is Here"));
        Assert.AreEqual("", Exercices.LongestWord(""));
        Assert.AreEqual("Test", Exercices.LongestWord("Test"));
    }
}