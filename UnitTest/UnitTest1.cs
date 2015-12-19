using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LRSkip;

namespace UnitTest
{
    [TestClass]
    public class LRSkip_UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            String KeyWord = @"This is a Pen.";
            String Result;

            LRSkip.
            CS_Lskip lskip = new CS_Lskip();
            lskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");

            CS_Rskip rskip = new CS_Rskip();
            rskip.Clear();
            rskip.Wbuf = KeyWord;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
        }
    }

    [TestClass]
    public class LRSkip_UnitTest2
    {
        [TestMethod]
        public void TestMethod()
        {
            String KeyWord = @"     This is a Pen.     ";
            String Result;

            CS_Lskip lskip = new CS_Lskip();
            lskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.     ", Result, @"lskip[     This is a Pen.     ] = [This is a Pen.     ]");

            CS_Rskip rskip = new CS_Rskip();
            rskip.Clear();
            rskip.Wbuf = KeyWord;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"     This is a Pen.", Result, @"rskip[     This is a Pen.     ] = [     This is a Pen.]");

            lskip.Clear();
            rskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            rskip.Wbuf = lskip.Wbuf;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip & rskip[     This is a Pen.     ] = [This is a Pen.]");
        }
    }
}
