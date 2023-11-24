using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;
namespace TestProject
{
    [TestClass]
    public class ArrayTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "3,0", "3,0", "-7.8", "wjekev6,8", "8", "5", "2124,21" };
            float[] array2 = Arrays.Arrays.FlotifyArray(array);
            float[] expected_res = { 3f, 3f, -7.8f, 0f, 8f, 5f, 2124.21f };
            for (int i = 0; i < array2.Length; i++)
            {
                Assert.AreEqual(expected_res[i], array2[i]);
            }
            //jAssert.AreEqual(expected_res[0], array2[0]);
        }
    }
}