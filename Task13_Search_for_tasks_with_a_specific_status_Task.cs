using System;

namespace CSharp_Practice
{
    public class Task
    {
        public string Title
        {
            get;
            set;
        }

        public TaskStatus StatusOfTask
        {
            get;
            set;
        }
        public Task(string title, TaskStatus statusOfTask)
        {
            Title = title;
            StatusOfTask = statusOfTask;
        }
    }
}
