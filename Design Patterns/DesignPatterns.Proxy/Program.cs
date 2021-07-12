namespace DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Image realImage = new RealImage("real.jpg");
            realImage.Display();

            Image proxyImage = new ProxyImage("proxy.jpg");
            proxyImage.Display();
        }
    }
}
