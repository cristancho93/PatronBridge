namespace ConsoleApplication1
{
    /// <summary>
    /// La interface LEDTV tiene los tres metodos SwitchOn, SwitchOff, SetChannel
    /// esta interface sera inmplementada por los por las demas clases
    /// </summary>
    public interface LEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}