namespace DataBunch.foundation.models
{
    public abstract class Model
    {
        protected Model(long id = -1)
        {
            this.ID = id;
        }

        public bool isNull()
        {
            return ID == -1;
        }

        public long ID { get; set; }

        public override string ToString()
        {
            return "Model: ID => " + ID;
        }
    }
}