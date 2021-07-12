using System;

namespace DesignPatterns.Decorator
{
    class DefaultMail : IMail
    {
        private readonly string _from;
        private readonly string _to;

        public DefaultMail(string @from, string to)
        {
            this._from = @from;
            this._to = to;
        }

        public void Send()
        {
            Console.WriteLine("Mail, {0} kişisinden {1} kişine gidiyor.", _from, _to);
        }
    }
}
