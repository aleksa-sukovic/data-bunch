namespace DataBunch.foundation.db
{
    public class QueryParam
    {
        private static long counter = 1;

        public QueryParam(string name, object value, string opr = null, string boolOpr = null)
        {
            Name = name;
            Value = value;
            Operator = opr ?? "=";
            BooleanOpr = boolOpr ?? "AND";
            ID = counter++.ToString();
        }

        public string Name { get; set; }
        public object Value { get; set; }
        public string Operator { get; set; }
        public string BooleanOpr { get; set; }
        public string ID { get; }
    }
}
