namespace DataBunch.foundation.exceptions
{
    public class ItemNotFoundException: BaseException
    {
        public ItemNotFoundException(string message = null) : base("Item not found", "The requested item could not be found.", message) { }
    }
}
