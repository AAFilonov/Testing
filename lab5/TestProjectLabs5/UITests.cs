using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectLabs5
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class UITests :TestSession
    {
        public UITests()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

       

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
           
         


        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        public void TestFind()
        {

            var textBoxFindNum = session.FindElementByAccessibilityId("textBoxFindNum");
            var buttonFind = session.FindElementByAccessibilityId("buttonFind");

            textBoxFindNum.SendKeys("а123а");
            buttonFind.Click();

            Assert.AreEqual(session.FindElementByAccessibilityId("textBoxNumberFind").Text, "а123а");
            Assert.AreEqual(session.FindElementByAccessibilityId("textBoxBrandFind").Text, "Шкода");
        }


        [TestMethod]
        public void TestAdd()
        {

            var textBoxNumberAdd = session.FindElementByAccessibilityId("textBoxNumberAdd");
            var buttonFind = session.FindElementByAccessibilityId("textBoxBrandAdd");
            var numericUpDownCostAdd = session.FindElementByAccessibilityId("numericUpDownCostAdd");
            var numericUpDownCostPerDayAdd = session.FindElementByAccessibilityId("numericUpDownCostPerDayAdd");
            var comboBoxTypeAdd = session.FindElementByAccessibilityId("comboBoxTypeAdd");
            var buttonAdd = session.FindElementByAccessibilityId("buttonAdd");

            textBoxNumberAdd.SendKeys("е678е");
            buttonFind.SendKeys("Лада");
            numericUpDownCostAdd.SendKeys("1000");
            numericUpDownCostPerDayAdd.SendKeys("100");

            comboBoxTypeAdd.Click();
            comboBoxTypeAdd.SendKeys(Keys.Down);
            comboBoxTypeAdd.SendKeys(Keys.Enter);

            buttonAdd.Click();

            Assert.AreEqual(session.FindElementByAccessibilityId("labelSucess").Text, "Succes!");


        }
    }
}
