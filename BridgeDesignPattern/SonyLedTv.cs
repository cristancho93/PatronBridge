using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// Esta clase implementa los metodos de la interface LEDTV
    /// y dara funcionalidad al control remoto para el televisor sony
    /// </summary>
    public class SonyLedTv: LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }
}