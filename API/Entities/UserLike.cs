using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UserLike
    {
        // The user that is liking the other user
        public AppUser SourceUser { get; set; }
        public int SourceUserId { get; set; }

        public AppUser LikedUser { get; set; }
        public int LikedUserId { get; set; }
    }
}