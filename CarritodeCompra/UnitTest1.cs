using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using FluentAssertions;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions full = new ChromeOptions();
            full.AddArgument("start-maximized");
            ChromeDriver driver = new ChromeDriver(full);

            driver.Url = "https://go.tradegecko.com/login";
            string email = "fabio.vaz93@gmail.com";
            string password = "------";
            string fecha  ;
            driver.FindElement(By.XPath("//input[@id='user_email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='user_password']")).SendKeys(password);

            driver.FindElement(By.XPath("//input[@name='commit']")).Click();

            driver.FindElement(By.XPath("//span[@class='nav-label' and text()='Inventory']")).Click();
            driver.FindElement(By.XPath("//div[@title='Cocktail Dress' and  @class='ember-view ember-table-cell']")).Click();            
            fecha= driver.FindElement(By.XPath("//div[@title='Cocktail Dress' and  @class='ember-view ember-table-cell']//following::time")).Text;

            Console.WriteLine (fecha);
           
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
