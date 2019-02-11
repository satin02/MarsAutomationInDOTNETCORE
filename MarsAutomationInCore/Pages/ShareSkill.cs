using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsAutomationInCore
{
    class ShareSkill
    {
        private IWebDriver driver;

        public ShareSkill (IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Initialize WebElements
        //Finding Share Skill Btn
        public IWebElement ShareSkillBtn => driver.FindElement(By.XPath("//div[@class = 'right item']/a"));

        //Finding Title Field
        IWebElement TitleFld => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));


        //Identifying Skill title for verification IList implemented previously
        //IWebElement Title => driver.FindElement(By.XPath( "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[3]"));


        //Finding Description Field
        IWebElement DescriptionFld => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));


        //Finding Category dropdown
        IWebElement Category => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));


        //Finding Sub Category dropdown
        IWebElement SubCategory => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));


        //Finding Tags Field
        IWebElement Tag => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));


        //Finding Hourly Basis Service Type radio button
        IWebElement ServiceType1 => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));


        //Finding Oneoff Service Type radio button
        IWebElement ServiceType2 => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));


        //Finding label for radio button
        IWebElement radiocheck => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/label"));


        //Finding On-Site Location Type radio button
        IWebElement OnSite => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));


        //Finding Online Location Type radio button
        IWebElement Online => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/label"));


        //Finding Label for Online
        IWebElement Location => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));


        //Finding Start Date
        IWebElement StartDate => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));


        //Finding End Date
        IWebElement EndDate => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));


        //Finding Day checkbox
        IWebElement Day => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));


        //Finding name of day
        IWebElement NameofDay => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/label"));


        //Finding Start TIme for day
        IWebElement StartTime => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));


        //Finding End Time for day
        IWebElement EndTIme => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));


        //Finding Skill Exchange radio button
        IWebElement SkillExchange => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));


        //Finding Credit radio button
        IWebElement Credit => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));


        //Finding label for Credit
        IWebElement CreditLabel => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/label/text()"));


        //Finding Credit field
        IWebElement CreditAmt => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));


        //Finding SkillExchange Tag Field
        // [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/input")]
        // private IWebElement SkillExcTag { get; set; }

        //Finding Upload Work Sample Btn
        IWebElement WorkSample => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));


        //Finding Active Status Btn
        IWebElement Active => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));


        //Finding Hidden Status Btn
        IWebElement Hidden => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));


        //Finding Hidden Label
        IWebElement StatusHidden => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/label"));


        //Finding Save Btn
        IWebElement SaveBtn => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));

        #endregion
    }
}
