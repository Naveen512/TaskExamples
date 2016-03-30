using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExam_3
    {
        static void Main()
        {

            Task taskA = Task.Run(
                 () => { Thread.Sleep(10000); }
                );
            Console.WriteLine("taskA Status {0}", taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine("taskA Status {0}", taskA.Status);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
