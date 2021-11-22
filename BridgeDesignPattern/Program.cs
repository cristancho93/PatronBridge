using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// La clase de cliente tiene el método Main. Por lo tanto, modifique el método Main como se muestra a continuación.
    /// Aquí, primero, usamos SonyRemoteControl y conectamos SonyLedTv para que podamos acceder a
    /// Sony Led TV de forma remota (es decir, encender, cambiar de canal y apagar).
    /// Así también podemos hacer lo mismo usando SamsungRemoteControl para acceder a SansungLedTv de forma remota.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();
            
            Console.WriteLine();
            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
            
            Console.ReadKey();
        }
    }
}