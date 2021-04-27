using System.Threading;

namespace Task8
{
    public class Healer2 : IHealer
    {
        public void Heal()
        {
            Thread.Sleep(10000);
        }
    }
}
