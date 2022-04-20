using Library1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1
{
    [TestClass]
    public class ApplicationTest
    {
        [TestMethod]
        public void GetApplicationTest()
        {
            Application application = new Application();
            application.GetApplication();
            Assert.IsNotNull(application);
        }

        [TestMethod]
        public void CreateTaskListTest()
        {
            Application application = new Application();
            application.CreateTaskList("App");
            int numberTaskListNames = application.GetTaskListNames().Count;
            Assert.IsTrue(numberTaskListNames == 1);
        }

        [TestMethod]
        public void GetTaskListNameTest()
        {
            Application application = new Application();
            application.CreateTaskList("App1");
            application.CreateTaskList("App2");
            application.CreateTaskList("App3");
            application.CreateTaskList("App4");
            int numberTaskListNames = application.GetTaskListNames().Count;
            Assert.IsTrue(numberTaskListNames == 4);
        }
    }
}
