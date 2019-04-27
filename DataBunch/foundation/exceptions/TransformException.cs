namespace DataBunch.foundation.exceptions
{
    public class TransformException: BaseException
    {
        public TransformException(string message = null): base("Transform Exception", "An error has occured while transforming data", message)
        {
            //
        }
    }
}
