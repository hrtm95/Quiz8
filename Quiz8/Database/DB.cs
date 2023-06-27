using Quiz8.Models;

namespace Quiz8.Database
{
    public static class DB
    {
        public static List<User> users = new List<User>()
          {
              new User(){ Id = 1,Name = "hamidreza", Email = "pootook18@gmail.com"},
              new User(){ Id = 2,Name = "mohamad", Email = "pootook19@gmail.com"},
              new User(){ Id = 3,Name = "jafar", Email = "pootook20@gmail.com"},
              new User(){ Id = 4 ,Name = "mamali", Email = "pootook17@gmail.com"},
          };
    }
}
