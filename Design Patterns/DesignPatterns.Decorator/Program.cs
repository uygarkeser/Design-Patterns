using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = "Uygar Keser";
            var to = "Melih Orhan";
            IMail defaultMail = new DefaultMail(from, to);
            IMail digitalSignatureMail = new DigitalSignatureDecorator(defaultMail, "Uygar Keser - Inventiv Software Engineer");
            IMail encryptMail = new EncryptDecorator(digitalSignatureMail);
            encryptMail.Send();

            Console.ReadLine();
        }
    }
}
