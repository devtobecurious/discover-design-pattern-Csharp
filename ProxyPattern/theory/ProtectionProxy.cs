using static ProxyPattern.SubjectAccessor;

namespace ProxyPattern
{
    public class ProtectionProxy : ISubject
    {
        Subject subject = null;

        public string Request()
        {
            string returnValue = "Erreur !";

            if(subject != null)
                returnValue = subject.Request();

            return returnValue;
        }

        public string Authenticate(string password)
        {
            string returnValue = "Error password !";

            if(! string.IsNullOrEmpty(password))
                if(subject == null)
                    subject = new Subject();

            return returnValue;
        }

    }
}