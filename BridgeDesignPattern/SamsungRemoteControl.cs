namespace ConsoleApplication1
{
    /// <summary>
    /// Esta es una clase concreta e implementa la clase abstracta AbstractRemoteControl y proporciona la implementación de los métodos SwitchOn, SwitchOff y SetChannel.
    /// En el constructor tenemos que adjuntar el LEDTV al que queremos acceder de forma remota.
    /// </summary>
    public class SamsungRemoteControl:AbstractRemoteControl
    {
        public SamsungRemoteControl(LEDTV ledTv) : base(ledTv)
        {
        }
        
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}