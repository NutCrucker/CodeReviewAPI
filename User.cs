using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIi
{
    public class User
    {
        private string id;
        private string username;
        private string fullname;
        private string profileurl;
        private string bio;
        private string website;
        private bool isbusiness;
        private Counts counts;   
        public User(string id, string username, string profile_picture, string full_name, string bio, string website, bool is_business, Counts counts)
        {
            ID = id;
            Username = username;
            Fullname = full_name;
            Profileurl = profile_picture;
            Bio = bio;
            Website = website;
            IsBusiness = is_business;
            Counts = counts;
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string Profileurl
        {
            get { return profileurl; }
            set { profileurl = value; }
        }
        public string Bio
        {
            get { return bio; }
            set { bio = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public bool IsBusiness
        {
            get { return isbusiness; }
            set { isbusiness = value; }
        }
        public Counts Counts
        {
            get { return counts; }
            set { counts = value; }
        }
    }
}