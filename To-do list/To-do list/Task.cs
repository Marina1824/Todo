using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    class Task
    {
        public string nametask;
        public string priority;
        public DateTime date;
        public int number;

        public string GetResult()  
        {
            return "Номер " + number + "\r\n" + "Задача: " + nametask + "\r\n" + "Приоритет: " + priority + "\r\n" + "Дата: " + date.ToShortDateString() + "\r\n" ;
        }

     
      
        public void PrintResults()
        {
            Console.WriteLine("Номер " + number + "\r\n" + "Задача: " + nametask + "\r\n" );

        }
    }
    
}
