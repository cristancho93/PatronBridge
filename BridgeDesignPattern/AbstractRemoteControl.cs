namespace ConsoleApplication1
{
    /// <summary>
    /// Esta es una clase abstracta que tiene tres métodos abstractos ( SwitchOn, SwitchOff y SetChannel ).
    /// Tiene una variable protegida ledTv que estará disponible para las subclases.
    /// </summary>
    public abstract class AbstractRemoteControl
    {
        protected LEDTV ledTv;
        protected AbstractRemoteControl(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}