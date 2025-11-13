using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_Practice
{
    public class TaskManager
    {
        public static void FindTasksByStatus(TaskStatus status, ArrayList tasks)
        {
            List<Task> results = tasks.Cast<Task>().ToList(); // Задать вопрос Что это?
            ArrayList showTitles = new ArrayList();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (results[i].StatusOfTask == status)
                {
                    showTitles.Add(results[i].Title);
                }
            }

            Console.Write($"Задачи со статусом {status}: ");
            for (int k = 0; k < showTitles.Count; k++)
            {
                if (k == showTitles.Count - 1)
                {
                    Console.Write($"{showTitles[k]}. ");
                    break;
                }
                Console.Write($"{showTitles[k]}, ");
            }
            Console.WriteLine();
            CountTasksWithStatusNew(results);
        }

        public static void CountTasksWithStatusNew(List<Task> results)
        {
            int numberOfNewTasks = 0;
            try
            {
                foreach (var task in results)
                {
                    if (task.StatusOfTask == TaskStatus.New) numberOfNewTasks++;
                }
                Console.WriteLine($"Количество задач со статусом New: {numberOfNewTasks}");
            }
            catch
            {
                Console.WriteLine($"задач со статусом NEW нет");
                return;
            }
        }
    }
}
//Поиск задач с определённым статусом.
//Подсчёт задач со статусом New.
//Исключение, если задач нет.

//CountTasksWithStatusNew() – возвращает количество задач со статусом New.

//Вывод:
//Задачи со статусом New: Задача 1, Задача 3  
//Количество задач со статусом New: 2