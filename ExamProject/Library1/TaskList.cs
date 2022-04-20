using System;
using System.Collections.Generic;
using System.Linq;

namespace Library1
{
    public class TaskList
    {
        private string name { get; set; }
        private List<Task> tasks { get; set; }

        /// <summary>
        /// инициализирует список задач с указанным именем
        /// </summary>
        /// <param name="name"> имя списка задач</param>
        public TaskList(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        /// <summary>
        /// возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// добавляет задачу в список задач
        /// </summary>
        /// <param name="task"> задача </param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// удаляет задачу из списка задач
        /// </summary>
        /// <param name="task">задача</param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }

        /// <summary>
        /// возвращает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> getTaskByToday()
        {
            List<Task> listTaskByToday = tasks.Where(t => t.due == DateTime.Now).ToList();
            return listTaskByToday;
        }

        /// <summary>
        /// возвращает задачи на завтра и позже в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> getTaskByFuture()
        {
            List<Task> listTaskByFuture = tasks.Where(t => t.due > DateTime.Now).ToList();
            return listTaskByFuture;
        }
    }
}
