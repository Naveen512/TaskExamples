using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExam_2
    {
        static void Main()
        {
            Task t = Task.Factory.StartNew(
                  () =>
                  {

                      int count = 0;
                      for (count = 0; count < 1000; count++)
                      {

                      }
                      Console.Write(" Total count = {0} ", count);

                  }
                );

            Console.WriteLine(" Before t.wait() ");
            Console.WriteLine(" Before t.wait()2 ");
            Console.WriteLine(" Before t.wait()3 ");
            Console.WriteLine(" Before t.wait()4 ");
            Console.WriteLine(" Before t.wait()5 ");
            Console.WriteLine(" Before t.wait()6 ");

            t.Wait();

            Console.Write(" After t.wait() ");
            Console.ReadKey();
        }
    }
}
