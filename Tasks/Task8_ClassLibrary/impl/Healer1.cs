using System.Threading;

namespace Task8
{
    public class Healer1 : IHealer
    {
        public void Heal()
        {
            Thread.Sleep(11000);
        }
    }
}
