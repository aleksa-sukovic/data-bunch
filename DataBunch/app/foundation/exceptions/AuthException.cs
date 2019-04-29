namespace DataBunch.app.foundation.exceptions
{
    public class AuthException: BaseException
    {
        public AuthException(string message = "") : base("Auth Error", message, message) { }
    }
}
