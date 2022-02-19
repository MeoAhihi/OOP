using System;
using System.Collections;
namespace Worker
{
    class WorkerList
    {
        public ArrayList workerList = new ArrayList();
        public WorkerList(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                System.Console.Write("First Name: "); string firstName = Console.ReadLine();
                System.Console.Write("Last Name: "); string lastName = Console.ReadLine();
                System.Console.Write("Number of products: "); int product = int.Parse(Console.ReadLine());
                workerList.Add(new Worker(i, firstName, lastName, product));
            }
        }
        public void AddWorker()
        {
            System.Console.Write("ID :"); int id = int.Parse(Console.ReadLine());
            System.Console.Write("First Name: "); string firstName = Console.ReadLine();
            System.Console.Write("Last Name: "); string lastName = Console.ReadLine();
            System.Console.Write("Number of products: "); int product = int.Parse(Console.ReadLine());
            workerList.Add(new Worker(id, firstName, lastName, product));
        }
        public void printAll() {
            System.Console.WriteLine("List of all workers");
            Worker.Title();
            foreach (Worker worker in workerList) worker.toString();
            Worker.End();
        }
        public int NumberOfWorkers() { return workerList.Count; }
        public void printAbove200() {
            System.Console.WriteLine("List of all workers");
            Worker.Title();
            foreach (Worker worker in workerList) if (worker.Product > 200) worker.toString();
            Worker.End();
        }
        public void Sort() {
            workerList.Sort();
        }
    }
}