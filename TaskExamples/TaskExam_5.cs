using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExam_5
    {
        static void Main()
        {
            var task = new Task[3];
            var rnd = new Random();

            for (int ctr = 0; ctr < 3; ctr++)
                task[ctr] = Task.Run(
                    () => { Thread.Sleep(rnd.Next(300, 5000)); }
                    );

            int index = Task.WaitAny(task);
            Console.WriteLine("Task #{0} completed first", task[index].Id);

            foreach (var t in task)
                Console.WriteLine("Task #{0} Status:{1} ", t.Id, t.Status);
            Console.ReadKey();
        }
    }
}
