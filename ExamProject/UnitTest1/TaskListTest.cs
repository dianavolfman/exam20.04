using Library1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1
{
    [TestClass]
    public class TaskListTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            string name1 = "Task1";
            TaskList taskList = new TaskList(name1);
            string name2 = taskList.GetName();
            Assert.AreEqual(name1, name2);
        }

        [TestMethod]
        public void AddTaskTest()
        {
            Task task1 = new Task("t1", false);
            TaskList taskList = new TaskList("Task2");
            taskList.AddTask(task1);
            int numberList = taskList.GetTasks().Count;
            Assert.IsTrue(numberList.Equals(1));
        }

        [TestMethod]
        public void GetTasksTest()
        {
            TaskList taskList = new TaskList("Task3");
            taskList.AddTask(new Task("t1", false));
            taskList.AddTask(new Task("t2", false));
            taskList.AddTask(new Task("t3", false));
            taskList.AddTask(new Task("t4", false));
            int numberList = taskList.GetTasks().Count;
            Assert.IsTrue(numberList.Equals(4));
        }

        [TestMethod]
        public void RemoveTest()
        {
            TaskList taskList = new TaskList("Task4");
            Task task = new Task("t1", false);
            taskList.AddTask(task);
            taskList.Remove(task);
            int numberList = taskList.GetTasks().Count;
            Assert.IsTrue(numberList.Equals(0));
        }
    }
}
