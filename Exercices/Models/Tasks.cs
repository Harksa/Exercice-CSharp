using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicesBase.Models
{
    class Tasks
    {
        
        static readonly object _lock = new object();

        public void SimpleTasks() {
            Task task1 = new Task(WaitForMe);
            Task task2 = new Task(delegate{ Console.WriteLine("Task 2"); });
            Task task3 = new Task(() => { Console.WriteLine("Task 3"); });

            task1.Start();
            Task.Run(() => { Console.WriteLine("Direct run"); });

            task1.Wait();

            Task<string> taskResult = Task.Run(() => { return "Bonjour"; });
            Console.WriteLine(taskResult.Result);

            Console.WriteLine("Debut launchTask");
            launchTask();
            Console.WriteLine("Après launchTask");

            for (int i = 0; i < 10; i++) {
                Task.Run(() =>
                { // Lock on the readonly object.
                    lock (_lock)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine(Environment.TickCount);
                    }
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                });
            }
        }

        private static async void launchTask() {
            Console.WriteLine("Debut du task");
            var message = await Task.Run(() => {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Sleep done");
                return "Retour du task";
            });
            Console.WriteLine("Fin de la tache await");
            Console.WriteLine(message);
        }

        private static void WaitForMe() {
            Console.WriteLine("Debut processus long");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Fin processus long");
        }
    }
}
