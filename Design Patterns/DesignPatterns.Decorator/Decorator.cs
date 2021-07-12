namespace DesignPatterns.Decorator
{
    public abstract class Decorator : IMail
    {
        private readonly IMail mail;

        protected Decorator(IMail mail)
        {
            this.mail = mail;
        }
        public virtual void Send()
        {
            mail.Send();
        }
    }
}
