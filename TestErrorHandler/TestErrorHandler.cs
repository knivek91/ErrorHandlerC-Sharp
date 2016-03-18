using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ErrorHandler;
using System.Collections.Generic;

namespace TestErrorHandler
{
    [TestClass]
    public class TestErrorHandler
    {
        [TestMethod]
        public void Test_IndexOutOfRangeException()
        {
            try
            {
                string[] a = new string[0];
                a[5] = "5";
            }
            catch (Exception ex)
            {
                string a = clsErrorHandler.getInstancia.checkError(ex);
                Assert.AreEqual(a, "IndexOutOfRangeException");

            }

        }

        [TestMethod]
        public void Test_NullReferenceException()
        {
            try
            {
                object o = null;
                o.ToString();
            }
            catch (Exception ex)
            {
                string a = clsErrorHandler.getInstancia.checkError(ex);
                Assert.AreEqual(a, "NullReferenceException");
            }

        }

        [TestMethod]
        public void Test_InvalidOperationException()
        {
            try
            {
                List<int> lst = new List<int>();
                lst.Add(0); lst.Add(1); lst.Add(2);

                foreach (int number in lst)
                {
                    if (number == 2) lst.Remove(number);
                }
            }
            catch (Exception ex)
            {
                string a = clsErrorHandler.getInstancia.checkError(ex);
                Assert.AreEqual(a, "InvalidOperationException");
            }
        }

        [TestMethod]
        public void Test_ArgumentNullException()
        {
            try
            {
                String s = null;
                "Calculate".IndexOf(s);
            }
            catch (Exception ex)
            {
                string a = clsErrorHandler.getInstancia.checkError(ex);
                Assert.AreEqual(a, "ArgumentNullException");
            }

        }

        [TestMethod]
        public void Test_ArgumentOutOfRangeException()
        {
            try
            {
                // Have to reply the error for testing
            }
            catch (Exception ex)
            {
                string a = clsErrorHandler.getInstancia.checkError(ex);
                Assert.AreEqual(a, "ArgumentOutOfRangeException");
            }

        }
    }
}
