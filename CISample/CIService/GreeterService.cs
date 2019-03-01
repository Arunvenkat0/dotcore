using System;

namespace CIService
{
    public class GreeterService
    {
        public string GetGreetText(string name)
        {
            return "Hello " + name + "!";
        }
    }
}
