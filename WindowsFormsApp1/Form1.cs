using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            IWebDriver driver = new ChromeDriver();
            VideoDataDriver VideoDatadDiver = new VideoDataDriver();
            VideoData CurrentVideo = new VideoData();
            PlayVideo PV;

            for (int i = 1; i < VideoDatadDiver.VideoFileContent.Count - 1; i++)
            {
                CurrentVideo = (VideoData)VideoDatadDiver.VideoFileContent[i];

                PV = new PlayVideo(driver, CurrentVideo);
                bool result = false;
                try
                {
                    result = PV.PlayVideoPage();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                Thread.Sleep(CurrentVideo.WaitTime);
            }

            driver.Quit();
            MessageBox.Show("Testing is finished for selected gate");

        }
    }
}




