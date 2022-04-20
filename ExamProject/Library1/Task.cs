using System;

namespace Library1
{
    public class Task
    {
        public string title { get; set; }
        public DateTime due { get; set; }
        public Boolean done { get; set; }

        /// <summary>
        /// инициализирует задачу 
        /// </summary>
        /// <param name="title">название задачи</param>
        /// <param name="done">статус выполнения</param>
        public Task(string title, Boolean done)
        {
            this.title = title;
            this.done = done;
            due = DateTime.Now;
        }
    }
}
