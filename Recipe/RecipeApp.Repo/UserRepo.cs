using RecipeApp.Database;
using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.Repo
{
    public class UserRepo : IUserRepo
    {
        public List<User> GetAll()
        {
            return DbImprovisation.GetUserList();
        }

        public User GetById(int id)
        {
            return DbImprovisation.GetUserList().FirstOrDefault(x => x.Id == id);
        }

    }
}
