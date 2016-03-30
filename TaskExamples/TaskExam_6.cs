using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExam_6
    {
        static void Main()
        {
            Task[] tasks = new Task[10];

            for (int ctr = 0; ctr < 10; ctr++)
                tasks[ctr] = Task.Run(
                    () => { Thread.Sleep(2000); }
                    );
            try
            {
                Task.WaitAll(tasks);
            }
            catch(AggregateException aExc)
            {
                Console.WriteLine("One or more Exceptions are occured");

                foreach (var ex in aExc.Flatten().InnerExceptions)
                {
                    Console.WriteLine(ex);
                }
            }

            foreach (var t in tasks)
                Console.WriteLine("Task #{0} Status {1}", t.Id, t.Status);

            Console.ReadKey();
        }
    }
}
