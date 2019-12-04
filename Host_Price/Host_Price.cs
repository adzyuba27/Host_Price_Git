// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Host_Price
{
    [TestFixture]
    public class Host_Price
    {
        [Test]
        public void fast_website_price_mount()
        {
            String price_main_int = "4";
            String price_main_dec = ".97";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://fozzy.com/ua-ru/shared-hosting.shtml");

            //System.Threading.Thread.Sleep(1000);

            IWebElement element_price_main_int = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[3]/div[1]/div/div[3]/div[1]/div/div[2]/div/div[2]/span[1]/div/span"));
            IWebElement element_price_main_dec = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[3]/div[1]/div/div[3]/div[1]/div/div[2]/div/div[2]/span[1]/div/span/span[1]"));

            Assert.IsTrue(element_price_main_int.Text.Contains(price_main_int));
            Assert.IsTrue(element_price_main_dec.Text.Contains(price_main_dec));

            driver.Close();
        }

        [Test]
        public void fast_website_price_year()
        {
            String price_main_int = "53";
            String price_main_dec = ".66";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://fozzy.com/ua-ru/shared-hosting.shtml");

            //System.Threading.Thread.Sleep(1000);

            IWebElement element_price_main_to_year = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[3]/div[1]/div/div[3]/div[1]/div/div[2]/div/div[2]/span[1]/div"));
            element_price_main_to_year.Click();

            IWebElement element_price_main_int = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[3]/div[1]/div/div[3]/div[1]/div/div[2]/div/div[2]/span[2]/div/span"));
            IWebElement element_price_main_dec = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[3]/div[1]/div/div[3]/div[1]/div/div[2]/div/div[2]/span[2]/div/span/span[1]"));

            Assert.IsTrue(element_price_main_int.Text.Contains(price_main_int));
            Assert.IsTrue(element_price_main_dec.Text.Contains(price_main_dec));

            driver.Close();
        }


    }
}
