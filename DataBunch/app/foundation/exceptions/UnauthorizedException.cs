using DataBunch.foundation.exceptions;

namespace DataBunch.app.foundation.exceptions
{
    public class UnauthorizedException: BaseException
    {
        public UnauthorizedException(string message = "You do not have sufficient permissions for this action."): base("Authorization Exception", message, message)
        {
            //
        }
    }
}
