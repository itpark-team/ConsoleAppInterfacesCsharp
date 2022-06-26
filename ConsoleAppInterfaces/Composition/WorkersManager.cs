using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Composition
{
    internal class WorkersManager
    {
        private List<Worker> workers = new List<Worker>();

        public WorkersManager()
        {
            workers = new List<Worker>()
            {
                new Worker("Ivan"),
                new Worker("Petr"),
                new Worker("Fedor")
            };
        }

        public void RunWork()
        {
            foreach (Worker worker in workers)
            {
                worker.Work();
            }
        }
    }
}
