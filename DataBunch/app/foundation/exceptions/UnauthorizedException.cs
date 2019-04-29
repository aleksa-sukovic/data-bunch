using DataBunch.foundation.exceptions;

namespace DataBunch.app.foundation.exceptions
{
    public class UnauthorizedException: BaseException
    {
        public UnauthorizedException(string message = ""): base("Authorization Exception", "You do not have sufficient permissions for this action.", message)
        {
            //
        }
    }
}
