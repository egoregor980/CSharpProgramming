using System;

namespace Task8
{
    public class Sportsmen : Subject
    {
        private static readonly Random random = new Random();

        private bool running = true;

        private readonly Compitition worker;

        public Sportsmen(string modelName) : base(modelName, 100)
        {
            this.worker = new Compitition();
            this.worker.ProgressEvent += (owner) =>
            {
                if (owner != this)
                {
                    return;
                }
                this.RaiseEvent($"Вручение награды({worker.Progress}%)");
                if (worker.Progress == 100)
                {
                    this.running = true;
                }
            };
            this.worker.Start();
        }

        protected override void Tick()
        {
            if (!this.running)
            {
                return;
            }

            var random = Sportsmen.random.NextDouble();
            if (random < 0.006)
            {
                this.running = false;
                if (random < 0.003)
                {
                    var @interface = InterfaceContainer.GetRandomInterface();
                    this.RaiseEvent($"Произошла травма. Ожидаем врача.");
                    @interface.ProgressEvent += (owner) =>
                    {
                        if (owner != this)
                        {
                            return;
                        }
                        this.running = true;
                    };
                    @interface.Request(this);
                }
                else
                {
                    worker.Request(this);
                }
            }

            if (this.running)
            {
                this.RaiseEvent("Соревнуется");
                return;
            }
        }
    }
}
