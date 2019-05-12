using System.Collections.Generic;
using DataBunch.app.foundation.models;

namespace DataBunch.app.ui.services
{
    public interface Refreshable<T> where T: Model
    {
        void refresh(List<T> toShow = null);
    }
}
