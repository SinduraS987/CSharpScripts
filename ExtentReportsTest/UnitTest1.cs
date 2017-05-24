using System;
using RelevantCodes.ExtentReports;
using NUnit.Framework;

namespace ExtentReportsTest
{
    [TestFixture]
    public class UnitTest1
    {
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void initialize()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "reports\\ExtentLogs01.html";
            extent = new ExtentReports(reportPath, true);
            extent
                .AddSystemInfo("Host Name", "TYSS")
                .AddSystemInfo("Environment", "Windows 10")
                .AddSystemInfo("User Name", "Vinodh Kumar T");
        }

        [Test]
        public void TestCase1()
        {
            test = extent.StartTest("Test Case 1");
            test.Log(LogStatus.Pass,"Step 1");
            test.Log(LogStatus.Pass, "Step 2");
            test.Log(LogStatus.Pass, "Step 3");
            extent.EndTest(test);
        }

        [Test]
        [Ignore("")]
        public void TestCase2()
        {
            test = extent.StartTest("Test Case 2");
            test.Log(LogStatus.Pass, "Step 1");
            test.Log(LogStatus.Pass, "Step 2");
            test.Log(LogStatus.Pass, "Step 3");
            extent.EndTest(test);
        }

        [Test]
        [Ignore("")]
        public void TestCase3()
        {
            test = extent.StartTest("Test Case 3");
            test.Log(LogStatus.Pass, "Step 1");
            test.Log(LogStatus.Pass, "Step 2");
            test.Log(LogStatus.Fail, "Step 3");
            extent.EndTest(test);
        }

        [Test]
        [Ignore("")]
        public void TestCase4()
        {
            test = extent.StartTest("Test Case 4");
            test.Log(LogStatus.Pass, "Step 1");
            test.Log(LogStatus.Fail, "Step 2");
            test.Log(LogStatus.Fail, "Step 3");
            extent.EndTest(test);
        }

        [Test]
        [Ignore("")]
        public void TestCase5()
        {
            test = extent.StartTest("Test Case 5");
            test.Log(LogStatus.Fail, "Step 1");
            test.Log(LogStatus.Fail, "Step 2");
            test.Log(LogStatus.Fail, "Step 3");
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        [Ignore("")]
        public void cleanup()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
