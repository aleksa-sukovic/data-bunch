namespace DataBunch.app.foundation.models
{
    public class Model
    {
        public Model(long id = -1)
        {
            this.ID = id;
        }

        public bool isNull()
        {
            return ID == -1;
        }

        public long ID { get; }

        public override string ToString()
        {
            return "Model: ID => " + ID;
        }
    }
}
