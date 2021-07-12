using System;

namespace DesignPatterns.Decorator
{
    public class DigitalSignatureDecorator : Decorator
    {
        private string _imza;
        public DigitalSignatureDecorator(IMail mail, string imza) : base(mail)
        {
            this._imza = imza;
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine(_imza + " olarak imzalandı");
        }
    }
}
