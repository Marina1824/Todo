using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace To_do_list
{
    class Add
    {
        public void addtask(List<Task> addtasks)
        {
            
            Console.WriteLine("Введите задачу");
            var nametask = Console.ReadLine();
            string priority = "";

            while ((priority != "HIGH") && (priority != "NORMAL") && (priority != "LOW"))
            {
                Console.WriteLine("Введите приоритет: HIGH, NORMAL, LOW ");
                priority = Console.ReadLine();
            }

            var datetask = DateTime.Now.AddDays(-1);

            while (datetask < DateTime.Today)
            {
                Console.WriteLine("Введите дату в формате дд.мм.гггг(при пропуске дата установится текущая)");
                var datestring = Console.ReadLine();

                if ((datestring != "")) //|| (datetask>=DateTime.Now))
                {
                    datetask = Convert.ToDateTime(datestring);
                }

                else
                {
                    datetask = DateTime.Today;
                }

                if (datetask < DateTime.Today)
                {
                    Console.WriteLine("Дата не может быть меньше текущей");
                }

            }

            var task = new Task();
            task.number = addtasks.Count+1;
            task.nametask = nametask;
            task.priority = priority;
            task.date = datetask;
            addtasks.Add(task);
            File.WriteAllText(@"todo.txt", "");
            foreach (Task alltask in addtasks)
            {
                File.AppendAllText(@"todo.txt", alltask.GetResult());
            }




        }
    }
}
