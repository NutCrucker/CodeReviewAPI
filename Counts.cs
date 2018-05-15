using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIi
{
    public class Counts
    {
        private int media;
        private int follows;
        private int followed_by;
        public Counts(int media, int follows, int followed_by)
        {
            Media = media;
            Follows = follows;
            FollowedBy = followed_by;
        }
        public int Media
        {
            get { return media; }
            set { media = value; }
        }
        public int Follows
        {
            get { return follows; }
            set { follows = value; }
        }
        public int FollowedBy
        {
            get { return followed_by; }
            set { followed_by = value; }
        }
    }
}
