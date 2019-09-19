using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestAdd()
        {
            IMagicalIntBagOfMagicalEntetiesOfMagic theBag = new MagicalIntBagOfMagicalEntetiesOfMagic();
            theBag.add(13);
            Assert.IsTrue(theBag.CountNumbersInBag() == 1);
        }
        
        [TestMethod]
        public void TestRemove()
        {
            IMagicalIntBagOfMagicalEntetiesOfMagic theBag = new MagicalIntBagOfMagicalEntetiesOfMagic();
            theBag.add(1252);
            theBag.add(2412);
            theBag.add(1953);
            theBag.add(65);
            theBag.add(19);
            theBag.add(108987678);
            theBag.add(1);
            theBag.add(1);
            theBag.add(1);
            theBag.add(1);
            theBag.add(1);
            theBag.remove();
            Assert.IsTrue(theBag.CountNumbersInBag() == 10);
        }
        
        [TestMethod]
        public void TestNumbersInBag()
        {
            IMagicalIntBagOfMagicalEntetiesOfMagic theBag = new MagicalIntBagOfMagicalEntetiesOfMagic();
            theBag.add(42);
            theBag.add(52535);
            theBag.add(3);
            theBag.CheckLowestNumber();
            Assert.IsTrue(theBag.CountNumbersInBag() == 3);
        }
        
        [TestMethod]
        public void TestTheLowestNumberis()
        {
            IMagicalIntBagOfMagicalEntetiesOfMagic theBag = new MagicalIntBagOfMagicalEntetiesOfMagic();
            theBag.add(1252);
            theBag.add(2412);
            theBag.add(1953);
            theBag.add(65);
            theBag.add(19);
            theBag.add(108987678);
            theBag.CheckLowestNumber();
            Assert.IsTrue(theBag.CheckLowestNumber() == 19);
        }
    }
}