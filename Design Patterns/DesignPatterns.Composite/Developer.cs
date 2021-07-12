using System;

namespace Design_Patterns
{
    class Developer : IEmployee
    {
        private string _name;
        private int _emplooyeId;
        private string _position;

        public Developer(int emplooyeId, string name, string position)
        {
            _emplooyeId = emplooyeId;
            _name = name;
            _position = position;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine(_emplooyeId + " " + _name + " " + _position);
        }
    }
}
