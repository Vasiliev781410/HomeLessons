using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp23
{


    class Program
    {

        static void Main(string[] args)
        {
            //1. Установим начальную дату
            LogicOperation.DateBeginSet();
            //2. Запустим отсчет
            while (true)
            {
                
                Thread thread = new Thread(LogicOperation.DateCurrentSet);
                thread.Name = "thread1";
                thread.Start();
                Thread.Sleep(2000);

                Thread thread1 = new Thread(WorkWithUserData.WorkWithUserDataMain);
                thread1.Name = "thread2";
                thread1.Start();

            }
                      
        }
    }
}
