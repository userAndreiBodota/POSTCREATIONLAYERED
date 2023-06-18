using System;
using Post_Data;
using Post_Models;

namespace Post_Rules
{
    internal class GetPostbyNumber
    {
        static Post GetPostByNumber(int postNumber)
        {
            foreach (var post in posts)
            {
                if (post.PostNumber == postNumber)
                {
                    return post;
                }
            }

            return null;
        }
    }
}
