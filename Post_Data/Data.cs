using System;
using System.Collections.Generic;
using Post_Models;

namespace Post_Data
{
    public class Data
    {
        static List<Account> accounts = new List<Account>();
        static List<Post> posts = new List<Post>();
        public static string loggedInUser = null;
    }
}
