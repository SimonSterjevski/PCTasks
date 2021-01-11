using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Repo
{
    public interface IRepo<T>
    {
        List<T> GetAll(string path);
        T GetById(Guid id, string path);
    }
}
