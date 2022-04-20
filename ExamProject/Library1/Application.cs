using System;
using System.Collections.Generic;
using System.Linq;

namespace Library1
{
    public class Application
    {
        private static Application _application { get; set; }
        public List<TaskList> _taskLists { get; set; }

        /// <summary>
        ///  инициализирует список со списком задач
        /// </summary>
        public Application()
        {
            _taskLists = new List<TaskList>();
        }

        /// <summary>
        /// возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (_application == null)
            {
                _application = new Application();
            }
            return _application;
        }

        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists
        /// </summary>
        /// <param name="name">имя списка задач</param>
        public void CreateTaskList(string name)
        {
            _taskLists.Add(new TaskList(name));
        }

        /// <summary>
        /// возвращает имена списков задач
        /// </summary>
        /// <returns></returns>
        public List<String> GetTaskListNames()
        {
            return _taskLists.Select(t => t.GetName()).ToList();
        }

        /// <summary>
        /// возвращает список задач по имени списка
        /// </summary>
        /// <param name="name">имя списка задач</param>
        /// <returns></returns>
        public TaskList GetTaskByName(string name)
        {
            return _taskLists.FirstOrDefault(t => t.GetName().Equals(name));
        }
    }
}
