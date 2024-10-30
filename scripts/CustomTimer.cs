using System;

namespace Timers
{
    public class CustomTimer {
        
        public int Id { get; private set; }
        public int Value { get; private set; }
        private Thread? thread;
        private bool running;

        public CustomTimer(int Id) 
        {
            this.Id = Id;
            Value = 0;
            running = false;
        }

        public void Start()
        {
            running = true;
            thread = new Thread(Run);
            thread.Start();
        }

        public void Stop()
        {
            running = false;
            thread?.Join();
        }

        private void Run()
        {
            while (running)
            {
                Value++;
                Console.WriteLine($"Timer [{Id}]: {Value}");
                Thread.Sleep(1000);
            }
        }
    }
}