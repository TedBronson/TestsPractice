using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PracticeTests
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://the-internet.herokuapp.com/";
        }

        [Test]
        public void SelectCheckbox()
        {
            driver.Url = "http://the-internet.herokuapp.com/checkboxes";
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='checkboxes']/input[1]"));
            checkbox.Click();
            Assert.IsTrue(checkbox.Selected);
        }

        [Test]
        public void VerifyCheckBoxIsChecked()
        {
            driver.Url = "http://the-internet.herokuapp.com/checkboxes";
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='checkboxes']/input[1]"));
            Assert.IsFalse(checkbox.Selected);
        }

        [Test]
        public void VerifyCheckBoxIsNotChecked()
        {
            driver.Url = "http://the-internet.herokuapp.com/checkboxes";
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='checkboxes']/input[2]"));
            Assert.IsTrue(checkbox.Selected);
        }

        [Test]
        public void CheckIfNotChecked()
        {
            driver.Url = "http://the-internet.herokuapp.com/checkboxes";
            IWebElement checkbox = driver.FindElement(By.XPath(".//*[@id='checkboxes']/input[2]"));
            if (checkbox.Selected is false)
            {
                checkbox.Click();
            }
            Assert.IsTrue(checkbox.Selected);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

    }
}
