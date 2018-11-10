using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_vk.com
{
    class User
    {
        public Response[] response;
        public class Response
        {
            public string sex;
            public string followers_count;
            public string status;
            public string deactivated;
            public string id;
            public string first_name;
            public string last_name;
            public string bdate;
            public string photo_100;
            public string online;


            public class Size
            {
                public string type { get; set; }
                public string url { get; set; }
                public int width { get; set; }
                public int height { get; set; }
            }

            public class Photo
            {
                public int id { get; set; }
                public int album_id { get; set; }
                public int owner_id { get; set; }
                public List<Size> sizes { get; set; }
                public string text { get; set; }
                public int date { get; set; }
            }

            public class Link
            {
                public string url { get; set; }
                public string title { get; set; }
                public string caption { get; set; }
                public string description { get; set; }
                public Photo photo { get; set; }
            }

            public class Attachment
            {
                public string type { get; set; }
                public Link link { get; set; }
            }

            public class PostSource
            {
                public string type { get; set; }
            }

            public class Comments
            {
                public int count { get; set; }
                public int can_post { get; set; }
                public bool groups_can_post { get; set; }
                public int can_close { get; set; }
            }

            public class Likes
            {
                public int count { get; set; }
                public int user_likes { get; set; }
                public int can_like { get; set; }
                public int can_publish { get; set; }
            }

            public class Reposts
            {
                public int count { get; set; }
                public int user_reposted { get; set; }
            }

            public class Views
            {
                public int count { get; set; }
            }

            public class Item
            {
                public int id { get; set; }
                public int from_id { get; set; }
                public int owner_id { get; set; }
                public int date { get; set; }
                public string post_type { get; set; }
                public string text { get; set; }
                public int can_delete { get; set; }
                public int can_pin { get; set; }
                public int is_pinned { get; set; }
                public List<Attachment> attachments { get; set; }
                public PostSource post_source { get; set; }
                public Comments comments { get; set; }
                public Likes likes { get; set; }
                public Reposts reposts { get; set; }
                public Views views { get; set; }
            }

            public class Profile
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public int sex { get; set; }
                public string screen_name { get; set; }
                public string photo_50 { get; set; }
                public string photo_100 { get; set; }
                public int online { get; set; }
            }

            public class Response
            {
                public int count { get; set; }
                public List<Item> items { get; set; }
                public List<Profile> profiles { get; set; }
                public List<object> groups { get; set; }
            }

            public class RootObject
            {
                public Response response { get; set; }
            }
        }
    }
}
