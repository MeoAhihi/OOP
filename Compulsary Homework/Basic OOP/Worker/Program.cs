using System;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new WorkerList(0);
            list.workerList.Add(new Worker(1, "Ly", "Vi Phong", 900));
            list.workerList.Add(new Worker(2, "Luu", "Khoa Hoc", 500));
            list.workerList.Add(new Worker(3, "Le", "Xuan Quang", 700));
            list.workerList.Add(new Worker(4, "Ly", "Quoc Dan", 100));
            list.workerList.Add(new Worker(5, "Le Hoang", "Minh Thinh", 150));

            list.printAll();
            list.printAbove200();
            list.Sort();
            list.printAll();
        }
    }
}
