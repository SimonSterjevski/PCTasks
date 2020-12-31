using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Repo
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T GetById(Guid id);
    }
}
