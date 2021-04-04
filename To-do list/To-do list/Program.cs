using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;

namespace To_do_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();
            string answer = "0";
            while (answer != "6")
            {
                Console.WriteLine("Выбери, что ты хочешь сделать: \r\n" +
                                  "1 - Создать запись; \r\n" +
                                  "2 - Посмотреть список дел; \r\n" +
                                  "3 - Просмотреть созданную задачу; \r\n" +
                                  "4 - Отредактировать созданную задачу ;\r\n" +
                                  "5 - Удалить задачу; \r\n" +
                                  "6 - Выход.\r\n");
                answer = Console.ReadLine();
                if (answer == "1")

                {
                    var add = new Add();
                    add.addtask(tasks);
                }

                if (answer == "2")
                {
                    if (tasks.Exists(x => x.number > 0))
                    {
                        foreach (var alltask in tasks)
                        {
                            alltask.PrintResults();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Задач нет");
                    }
                }

                if (answer == "3")
                {
                    if (tasks.Exists(x => x.number > 0))
                    {
                        foreach (var onetask in tasks)
                        {
                            onetask.PrintResults();
                        }

                        Console.WriteLine("Выберите номер задачи на просмотр");
                        int numbertask = Convert.ToInt32(Console.ReadLine());
                        if (tasks.Exists(x => x.number == numbertask))
                        {
                            var task = tasks.First(x => x.number == numbertask);
                            Console.WriteLine(task.GetResult());
                        }
                        else
                        {
                            Console.WriteLine("Такой задачи нет");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Задач нет");
                    }

                }

                if (answer == "4")
                {
                    if (tasks.Exists(x => x.number > 0))
                    {
                        var update = new Update();
                        update.updatetask(tasks);
                    }
                    else
                    {
                        Console.WriteLine("Задач нет");
                    }
                }

                if (answer == "5")
                {
                    if (tasks.Exists(x => x.number > 0))
                    {
                        Console.WriteLine("Выберите номер задачи которую хотите удалить");
                        int numbertask = Convert.ToInt32(Console.ReadLine());
                        if (tasks.Exists(x => x.number == numbertask))
                        {
                            var task = tasks.First(x => x.number == numbertask);
                            tasks.Remove(task);
                            Console.WriteLine("Задача номер: " + numbertask + " успешно удалена");
                        }
                        else
                        {
                            Console.WriteLine("Задачи номер " + numbertask + " не существует");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Задач нет");
                    }
                }
            }
        }
    }
}