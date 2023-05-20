namespace API.Models
{
    public class User
    {
 
        public int Id { get; set; }

 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public User(int id, string name,string email, string password, string username)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            UserName= username;
        }

    }
}
