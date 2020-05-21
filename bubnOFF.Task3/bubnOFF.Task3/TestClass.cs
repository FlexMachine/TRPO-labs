using NUnit.Framework;
using ProductionCode;

namespace bubnOFF.Task3
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void testArrayProccessor()
        {
            //arange
            int[] actual = { -8, 5443, -20, 4559, 0, -20, 2, -1323, 10000, -1323 };
            int[] excepting = { -1323, -20, -8, 0, 2, 4559, 5443, 10000};

            //act
            ArrayProcessor arrProc = new ArrayProcessor();
            int[] result = arrProc.SortAndFilter(actual);

            //assert
            CollectionAssert.AreEqual(excepting, result);
        }
        [Test]
        public void testSameArray()
        {
            int[] actual = { -8, 5443, -20, 4559, 0, -20, 2, -1323, 10000, -1323 };
            int[] excepting = { -8, 5443, -20, 4559, 0, -20, 2, -1323, 10000, -1323 };

            //act
            ArrayProcessor arrProc = new ArrayProcessor();
            int[] result = arrProc.SortAndFilter(actual);

            //assert
            //Проверяем, то оригинальный массив не меняется 
            CollectionAssert.AreEqual(excepting, actual);
        }
    }
}
