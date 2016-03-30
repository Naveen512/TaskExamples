using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExam_4
    {
        static void Main()
        {
            try
            {

                Task task = Task.Run(
                    () => { Thread.Sleep(10000); }
                     );

                task.Wait(2000);

                bool completed = task.IsCompleted;

                Console.WriteLine("task status {0}, completed {1}", task.Status, completed);

                if(!completed)
                {
                    Console.WriteLine("Timed out before task was completed");
                }
                Thread.Sleep(10000);
                Console.WriteLine("task status {0}, completed {1}", task.Status, completed);
                Console.ReadKey();

            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
