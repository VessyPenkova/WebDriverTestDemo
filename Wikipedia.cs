using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Create new Chome brose instanse
var driver = new ChromeDriver();

//Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE:" + driver.Title);

//locate search field by ID
var searchField = driver.FindElement(By.Id("searchInput"));

//Click on the selected element
searchField.Click();

//fill QA
searchField.SendKeys("QA");

// press ENTER beyboard
searchField.SendKeys(Keys.Enter);

System.Console.WriteLine("TITLE AFTER SEARCH:" + driver.Title);

//Close broser
driver.Quit();


