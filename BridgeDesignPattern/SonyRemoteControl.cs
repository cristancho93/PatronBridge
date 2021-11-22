namespace ConsoleApplication1
{
    /// <summary>
    /// Esta también será una clase concreta y también implementará la clase AbstractRemoteControl y proporcionará
    /// la implementación de los métodos SwitchOn, SwitchOff y SetChannel .
    /// En el constructor, debe pasar el LEDTV al que desea acceder de forma remota.
    /// </summary>
    /// <param name="ledTv"></param>
    public class SonyRemoteControl: AbstractRemoteControl
    {
        public SonyRemoteControl(LEDTV ledTv) : base(ledTv)
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