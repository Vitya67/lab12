using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            taskManager.AddTask("Зробити домашнє завдання");
            taskManager.AddTask("Купити продукти");
            taskManager.AddTask("Прогулятися з собакою");

            taskManager.PrintTasks();

                                                     
            UserManager userManager = new UserManager(); // завдання 2

            userManager.AddUser(new User { id = 1, Name = "Андрій" });
            userManager.AddUser(new User { id = 2, Name = "Олександер" });

            userManager.PrintAllUsers();

            User foundUser = userManager.GetUserById(1);
            Console.WriteLine($"Found user: {foundUser.Name}");

            userManager.RemoveUser(1);
            userManager.PrintAllUsers();
        }
    }

    class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
    }
    class TaskManager
    {
        List<Task> tasks = new List<Task>();
        int nextTaskId = 1;

        public void AddTask(string description)
        {
            tasks.Add(new Task { TaskId = nextTaskId++, Description = description });
        }

        public void RemoveTask(int taskId)
        {
            tasks.RemoveAll(task => task.TaskId == taskId);
        }

        public void PrintTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Id: {task.TaskId}, Опис: {task.Description}");
            }
        }

    }
}