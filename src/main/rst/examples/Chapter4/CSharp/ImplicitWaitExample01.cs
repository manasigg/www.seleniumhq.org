using (IWebDriver driver = new FirefoxDriver())
{
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    driver.Url = "http://somedomain/url_that_delays_loading";
    IWebElement myDynamicElement = driver.FindElement(By.Id("someDynamicElement"));
}
