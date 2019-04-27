using System;
using System.Data;

namespace DataBunch.foundation.utils
{
    public class DbParam
    {
        private static long counter = 1;
        
        public DbParam(string name, object value, SqlDbType type, string opr = null, string boolOpr = null)
        {
            Name = name;
            Value = value;
            Type = type;
            Operator = opr ?? "=";
            BooleanOpr = boolOpr ?? "AND";
            ID = counter++.ToString();
        }

        public string Name { get; set; }
        public object Value { get; set; }
        public string Operator { get; set; }
        public string BooleanOpr { get; set; }
        public SqlDbType Type { get; set; }
        public string ID { get; }
    }
}
