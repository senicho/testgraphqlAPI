namespace testgraphqlAPI
{
    public class Query
    {
       

        public List<User> GetUsers()
        {

            List<User>  users = new List<User>();


            for (int i = 1; i < 10; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = "user " + i,
                    Email = "user" + i + "@test.com",
                });
            }
            return users;

        }
        public List<User> GetUsersbyNo( int n)
        {

            List<User> users  = new List<User>();


            for (int i = 1; i <= n; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = "user " + i,
                    Email = "user" + i + "@test.com",
                });
            }
            return users;

        }

        public User GetUsersById(int id)
        {

            User user = new User
            {
                Id = id,
                Name = "user " + id,
                Email = "user" + id + "@test.com",
            };


            return user;

        }

        public List<User> retrieve_Data(bool retrieve)
        {
            List<User> users= new List<User>();
            if (retrieve)
            {
                users = GetUsersbyNo(10);
            ///https://mocki.io/v1/d4867d8b‐b5d5‐4a48‐a4ab‐79131b5809b8.
            }
            else
                users = GetUsersbyNo(1);

            return users;
            

        }
    }
}
