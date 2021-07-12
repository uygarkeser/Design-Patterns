using System;

namespace DesignPatterns.Decorator
{
    public class EncryptDecorator : Decorator
    {
        public EncryptDecorator(IMail mail) : base(mail) { }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Şifrelendi  ");
        }
    }
}
