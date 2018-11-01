using System;
using static ProxyPattern.SubjectAccessor;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();

            System.Console.WriteLine(subject.Request());
             
            subject = new ProtectionProxy();

            System.Console.WriteLine((subject as ProtectionProxy).Authenticate("test"));

            System.Console.WriteLine(subject.Request());
        }
    }
}
