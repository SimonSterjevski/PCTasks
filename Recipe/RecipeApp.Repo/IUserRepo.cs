using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Repo
{
    public interface IUserRepo
    {
        List<User> GetAll();
        User GetById(int id);
    }
}
