namespace DataBunch.app.foundation.exceptions
{
    public class StorageException: BaseException
    {
        public StorageException(string message = "") : base("Storage Exception", message, message) { }
    }
}
