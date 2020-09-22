using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace WindowsFormsApp1
{

    public class PlayVideo
    {
        IWebDriver _driver;
        VideoData _currentVideo;

        public PlayVideo(IWebDriver Driver, VideoData CurrentVideo)
        {
            _driver = Driver;
            _currentVideo = CurrentVideo;
        }
        public bool PlayVideoPage()
        {
            _driver.Navigate().GoToUrl(_currentVideo.URL);

            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id=\"movie_player\"]/div[4]/button")));

            //_driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[4]/button")).Click();
            return true;
        }
    }
}



