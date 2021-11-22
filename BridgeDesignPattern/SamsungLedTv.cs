using System;
namespace ConsoleApplication1
{
    /// <summary>
    /// Esta clase implementa los metodos de la interface LEDTV
    /// y dara funcionalidad al control remoto para el televisor samsung
    /// </summary>
    public class SamsungLedTv: LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }
}