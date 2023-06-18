using System;
using Post_Data;
using Post_Models;

namespace Post_Rules
{
    public class GetAccountRule
    {
        static Account GetAccount(string username)
        {
            foreach (var account in accounts)
            {
                if (account.Username == username)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
