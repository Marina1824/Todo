using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace To_do_list
{
    class Update
    {
        public void updatetask(List<Task> usertasks)
        {
            Console.WriteLine("Выберите номер записи которую хотите отредактировать");
            int numbertask = Convert.ToInt32(Console.ReadLine());
            string answer2 = "";
            while (answer2 != "4")
            {

                if (usertasks.Exists(x => x.number == numbertask))
                {
                    var task = usertasks.First(x => x.number == numbertask);
                    Console.WriteLine(task.GetResult());
                    Console.WriteLine("Выберите, что вы хотите отредактировать:\r\n" +
                                      "1 - Название; \r\n" +
                                      "2 - Приоритет; \r\n" +
                                      "3 - Дату; \r\n" +
                                      "4 - Выход.");
                    answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        Console.WriteLine("Введите cписок дел ");
                        var nametask = Console.ReadLine();
                        task.nametask = nametask;
                    }

                    if (answer2 == "2")
                    {
                        string priority = "";
                        while ((priority != "HIGH") && (priority != "NORMAL") && (priority != "LOW"))
                        {
                            Console.WriteLine("Введите приоритет: HIGH, NORMAL, LOW ");
                            priority = Console.ReadLine();
                            task.priority = priority;
                        }
                    }

                    if (answer2 == "3")
                    {
                        var datetask = DateTime.Now.AddDays(-1);

                        while (datetask < DateTime.Today)
                        {
                            Console.WriteLine(
                                "Введите дату в формате дд.мм.гггг(при пропуске дата установится текущая) ");
                            var datestring = Console.ReadLine();

                            if ((datestring != "")) //|| (datetask>=DateTime.Now))
                            {
                                datetask = Convert.ToDateTime(datestring);
                                task.date = datetask;
                            }

                            if (datetask < DateTime.Today)
                            {
                                Console.WriteLine("Дата не может быть меньше текущей");
                            }

                        }
                    }

                }
            }
        }
    }
}
