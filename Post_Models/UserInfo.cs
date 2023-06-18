using System;

namespace Post_Models
{
    internal class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string StudentNumber { get; set; }

        public UserInfo(string username, string password, string name, string studentNumber)
        {
            Username = username;
            Password = password;
            Name = name;
            StudentNumber = studentNumber;
        }
    }
}
