namespace testgraphqlAPI
{
    public class Mutation
    {
        public Mutation()
        {
            _users= new List<User>();
        }
        private List<User> _users;
        public bool CreateUser(int id,string name, string email)
        {
            User user = new User()
            {
                Id = id,
                Name = name,
                Email = email

            };
            _users.Add(user);

            return true;

        }

    }
}
