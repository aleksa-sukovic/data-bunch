using System.Collections.Generic;

namespace DataBunch.app.foundation.db
{
    public class DbParams
    {
        private List<DbParam> dbParams;

        public DbParams(DbParam[] dbParams = null)
        {
            this.dbParams = dbParams != null ? new List<DbParam>(dbParams) : new List<DbParam>();
        }

        public bool contains(string key)
        {
            return this.get(key) != null ? true : false;
        }

        public DbParam get(string key)
        {
            foreach (var param in this.dbParams) {
                if (param.Name == key) {
                    return param;
                }
            }

            return null;
        }

        public int count()
        {
            return this.dbParams.Count;
        }

        public void add(DbParam value)
        {
            this.dbParams.Add(value);
        }

        public void remove(string key, bool multiple = true)
        {
            foreach (var param in this.dbParams) {
                if (param.Name != key) {
                    continue;
                }

                this.dbParams.Remove(param);

                if (!multiple) {
                    return;
                }
            }
        }

        public List<DbParam> get()
        {
            return this.dbParams;
        }

        public override string ToString()
        {
            var output = "[ ";

            foreach (var param in this.dbParams) {
                output += param.ToString();
                output += ", ";
            }

            output = output.Substring(0, output.Length - 2);

            return output + " ]";
        }
    }
}
