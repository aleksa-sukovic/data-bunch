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

        public long ID { get; set; }

        public override string ToString()
        {
            return "Model: ID => " + ID;
        }

        public virtual string[] ToArray()
        {
            return new string[ID];
        }
    }
}
