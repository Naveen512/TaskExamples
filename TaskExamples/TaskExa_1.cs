using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExamples
{
    public class TaskExa_1
    {
        static void Main(string[] args)
        {

            Task t= Task.Run(
                  () =>
                  {

                      int i = 0;
                      for (i = 0; i < 1000; i++)
                      {

                      }
                      Console.WriteLine(" Total i count is {0} ", i);

                  }
                );
            Console.WriteLine(" After task Before t.wait() ");
            t.Wait();

            Console.WriteLine(" After task after t.wait() ");
            Console.ReadLine();
        }
    }
}
