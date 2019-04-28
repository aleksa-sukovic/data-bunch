using System;
using System.Windows.Forms;

namespace DataBunch.foundation.exceptions
{
    public class BaseException: Exception
    {
        public BaseException(string title, string description, string message = ""): base(message)
        {
            this.Title = title;
            this.Description = description;
        }

        public void show()
        {
            MessageBox.Show(this.Description, this.Title);
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
