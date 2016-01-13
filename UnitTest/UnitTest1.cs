using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LRSkip;

namespace UnitTest
{
    [TestClass]
    public class LRSkip_UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region 対象：削除対象なし
            String KeyWord = @"This is a Pen.";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし
            CS_Lskip lskip = new CS_Lskip();
            lskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｌｓｋｉｐ：削除対象なし２
            lskip.Clear();
            lskip.Exec(KeyWord);
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし
            CS_Rskip rskip = new CS_Rskip();
            rskip.Clear();
            rskip.Wbuf = KeyWord;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region Ｒｓｋｉｐ：削除対象なし２
            rskip.Clear();
            rskip.Exec(KeyWord);
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region ＬＲｓｋｉｐ：削除対象なし
            CS_LRskip lrskip = new CS_LRskip();
            lrskip.Clear();
            lrskip.Wbuf = KeyWord;
            lrskip.Exec();
            Result = lrskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion

            #region ＬＲｓｋｉｐ：削除対象なし２
            lrskip.Clear();
            lrskip.Exec(KeyWord);
            Result = lrskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"rskip[This is a Pen.] = [This is a Pen.]");
            #endregion
        }
    }

    [TestClass]
    public class LRSkip_UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            #region 対象：左右空白５文字
            String KeyWord = @"     This is a Pen.     ";
            String Result;
            #endregion

            #region Ｌｓｋｉｐ：左空白５文字削除対象
            CS_Lskip lskip = new CS_Lskip();
            lskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            Result = lskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.     ", Result, @"lskip[     This is a Pen.     ] = [This is a Pen.     ]");
            #endregion

            #region Ｒｓｋｉｐ：右空白５文字削除対象
            CS_Rskip rskip = new CS_Rskip();
            rskip.Clear();
            rskip.Wbuf = KeyWord;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"     This is a Pen.", Result, @"rskip[     This is a Pen.     ] = [     This is a Pen.]");
            #endregion

            #region Ｌｓｋｉｐ・Ｒｓｋｉｐ：左右空白５文字削除対象
            lskip.Clear();
            rskip.Clear();
            lskip.Wbuf = KeyWord;
            lskip.Exec();
            rskip.Wbuf = lskip.Wbuf;
            rskip.Exec();
            Result = rskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip & rskip[     This is a Pen.     ] = [This is a Pen.]");
            #endregion

            #region ＬＲｓｋｉｐ：左右空白５文字削除対象
            CS_LRskip lrskip = new CS_LRskip();
            lrskip.Clear();
            lrskip.Exec(KeyWord);
            Result = lrskip.Wbuf;

            Assert.AreEqual(@"This is a Pen.", Result, @"lskip & rskip[     This is a Pen.     ] = [This is a Pen.]");
            #endregion
        }
    }
}
