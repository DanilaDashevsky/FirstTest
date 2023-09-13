using System.IO;
using SOLID;
using WorkTest.Classes;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPart1()
        {
            //Проверю метод ResultStrPart1 класса Part1 на корректность возвращаемых данных
            Part1 part = new Part1();
           Assert.AreEqual("fizz-buzz", part.ResultStrPart1(15));
           Assert.AreEqual("fizz", part.ResultStrPart1(9));
           Assert.AreEqual("buzz", part.ResultStrPart1(5));
           Assert.AreEqual("", part.ResultStrPart1(1));
        }


        [TestMethod]
        public void TestPart2()
        {
            //Проверю метод ResultStrPart1 класса Part2 на корректность возвращаемых данных
            Part2 part = new Part2();
            Assert.AreEqual("muzz-guzz", part.ResultStrPart1(28));
            Assert.AreEqual("muzz", part.ResultStrPart1(8));
            Assert.AreEqual("guzz", part.ResultStrPart1(14));
            Assert.AreEqual("", part.ResultStrPart1(1));
            Assert.AreEqual("fizz-buzz-muzz-guzz", part.ResultStrPart1(420));

        }
        [TestMethod]
        public void TestPart3()
        {
            //Проверю метод ResultStrPart3 класса Part1 на корректность возвращаемых данных
            Part3 part = new Part3();
            Assert.AreEqual("good-boy", part.ResultStrPart1(15));
            Assert.AreEqual("dog", part.ResultStrPart1(9));
            Assert.AreEqual("cat", part.ResultStrPart1(10));
            Assert.AreEqual("", part.ResultStrPart1(1));
            Assert.AreEqual("good-boy-muzz-guzz", part.ResultStrPart1(420));

        }
    }
}