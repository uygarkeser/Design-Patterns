using System;

namespace DesignPatterns.Proxy
{
    class RealImage : Image
    {
        private readonly string _imageName;

        public RealImage(string imageName)
        {
            this._imageName = imageName;
        }

        public void Display()
        {
            Console.WriteLine("RealImage: Displaying " + _imageName);
        }

        public void LoadFromDisk()
        {
            Console.WriteLine("RealImage: Loading " + _imageName);
        }
    }
}
