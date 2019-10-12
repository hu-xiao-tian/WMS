using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 仓库管理系统
{
    public class MultiThreadWork
    {
        public int ThreadCount { get; private set; }
        private Semaphore sema;

        private int threadNums = 0;
        public MultiThreadWork(int threadCount=1)
        {
            this.ThreadCount = threadCount;
            sema = new Semaphore(ThreadCount, ThreadCount);

        }
        public void DoMultiWork<T>(SpecificWork<T> work, T arg)
        {
            while (threadNums > ThreadCount)
            {
                Thread.Sleep(100);
            }

            sema.WaitOne();
            ThreadPool.QueueUserWorkItem(p =>
            {
                try
                {
                    Interlocked.Increment(ref threadNums);
                    work((T)p);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                sema.Release();
                Interlocked.Decrement(ref threadNums);
            }, arg);
        }

        public void WaitingFinish()
        {
            for (int i = 0; i < ThreadCount; i++)
            {
                sema.WaitOne();
            }
            sema.Release(ThreadCount);
        }
        public delegate void SpecificWork<in T>(T one);
    }
}
