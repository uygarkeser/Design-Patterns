using System;

namespace DesignPatterns.Proxy
{
    class ProxyImage : Image
    {
        private RealImage _realImage;
        private readonly string _imageName;

        public ProxyImage(string imageName)
        {
            _imageName = imageName;
        }

        public void Display()
        {
            Console.WriteLine("ProxyImage üzerinden erisim saglaniyor");

            _realImage = new RealImage(_imageName);

            if (IsCachedImage(false))
            {
                _realImage.LoadFromDisk();
            }
            else
            {
                _realImage.Display();
            }
        }

        public bool IsCachedImage(bool isCached)
        {
            return isCached;
        }
    }
}
