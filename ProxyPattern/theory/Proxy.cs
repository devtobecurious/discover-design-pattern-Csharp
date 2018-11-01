using static ProxyPattern.SubjectAccessor;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        Subject subject = null;

        public string Request()
        {
            if(subject == null)
                subject = new Subject();

            return subject.Request();
        }
    }
}