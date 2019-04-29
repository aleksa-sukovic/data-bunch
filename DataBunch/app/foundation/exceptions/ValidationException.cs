using DataBunch.foundation.exceptions;

namespace DataBunch.app.foundation.exceptions
{
    public class ValidationException: BaseException
    {
        public ValidationException(string message = "") : base("Validation Exception", message, "") { }
    }
}
