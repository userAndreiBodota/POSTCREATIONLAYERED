using System;
using Post_Data;
using Post_Models;

namespace Post_Rules
{
    internal class GetNextPostNumber
    {
        static int GetNextPostNumber()
        {
            if (posts.Count > 0)
            {
                return posts[posts.Count - 1].PostNumber + 1;
            }

            return 1;
        }
    }
}
