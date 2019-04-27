namespace DataBunch.user.models
{
    public class User
    {
        public User(long id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "User: ID => " + ID + " Name => " + Name + " Age => " + Age;
        }
    }
}
