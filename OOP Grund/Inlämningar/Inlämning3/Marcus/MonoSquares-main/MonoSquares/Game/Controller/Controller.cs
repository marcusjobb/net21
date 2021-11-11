using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonoSquares.Controllers
{
    class Controller
    {
        public Controller(Func<Task> func, int timer)
        {

            Task statisticsUploader = PeriodicAsync(func, TimeSpan.FromSeconds(timer));
        }

        public static async Task PeriodicAsync(Func< Task> action, TimeSpan interval, CancellationToken cancellationToken = default)
        {

            while (true)
            {
                var delayTask = Task.Delay(interval, cancellationToken);
                await action();
                await delayTask;
            }
        }
    }
}
