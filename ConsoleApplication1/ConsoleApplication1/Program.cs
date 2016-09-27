using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseURL = "http://puppies.herokuapp.com";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("input.rounded_button")).Click();
            driver.FindElement(By.CssSelector("input.rounded_button")).Click();
            driver.FindElement(By.Id("toy")).Click();
            driver.FindElement(By.Id("vet")).Click();
            driver.FindElement(By.XPath("//input[@value='Adopt Another Puppy']")).Click();
            driver.FindElement(By.XPath("(//input[@value='View Details'])[3]")).Click();
            driver.FindElement(By.CssSelector("input.rounded_button")).Click();
            driver.FindElement(By.XPath("(//input[@id='carrier'])[2]")).Click();
            driver.FindElement(By.Id("collar")).Click();
            driver.FindElement(By.CssSelector("input.rounded_button")).Click();
            driver.FindElement(By.Id("order_name")).Clear();
            driver.FindElement(By.Id("order_name")).SendKeys("Leonard Espiritu");
            driver.FindElement(By.Id("order_address")).Clear();
            driver.FindElement(By.Id("order_address")).SendKeys("automation avenue");
            driver.FindElement(By.Id("order_email")).Clear();
            driver.FindElement(By.Id("order_email")).SendKeys("jmalpartida@yahoo.com");
            new SelectElement(driver.FindElement(By.Id("order_pay_type"))).SelectByText("Credit card");
            driver.FindElement(By.Name("commit")).Click();
            Assert.AreEqual("Thank you for adopting a puppy!", driver.FindElement(By.Id("notice")).Text);
            driver.Quit();
        }
    }
}
