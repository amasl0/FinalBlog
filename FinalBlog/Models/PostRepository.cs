using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FinalBlog.Models;

namespace FinalBlog.Models
{
    public class PostRepository
    {
        public int action = 0;
        private int countPages = 0;
        private PostContext context = new PostContext();
        private static PostRepository rep = new PostRepository();
        private static List<Post> user = new List<Post>();
        private static List<Post> Posts = new List<Post>();
        private Post buffer = new Post();
        public static PostRepository Current
        {
            get
            {
                return rep;
            }
        }
        public Post Get(int id)
        {
                return context.Posts.Find(id);
                //Where(x => x.Id == id).FirstOrDefault();
        }

        public bool IsEmpty()
        {
            if (action == 0)
            {
                //context.Database.Delete();
                context.Database.Create();
                int i = context.Posts.Count();
                action++;
                return true;
            }
            else
                return false;
        }


        public int GetIndex(string Author)
        {
            return context.Posts.Where(x => x.Author == Author).FirstOrDefault().Id;
            //Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Post> GetAll()
        {
            return Posts;
        }

        public bool Update(Post item)
        {
           
            Post storedItem = Get(buffer.Id);
            Post UserInfo = user.Find(w => w.Author == item.Author);
            Post PostsInfo = Posts.Find(r => r.Author == item.Author);
            buffer = null;
            if (storedItem != null)
            {
                storedItem.Title = item.Title;
                storedItem.Description = item.Description;
                storedItem.Author = item.Author;
                UserInfo.Author = item.Author;
                UserInfo.Password = item.Password;
                PostsInfo.Author = item.Author;
                PostsInfo.Title = item.Title;
                return true;
                context.SaveChanges();
            }
            else
            {
                return false;
            }
        }

        public Post Add(Post item)
        {
            //item.Author = null; item.Title = null;
            //item.Description = null; item.Id = 0;
            //item.PasswordForEdit = null;



            if (item.Title != null &&
                item.Author != null &&
                item.Description != null)
            {
                //ShortInfo info = new ShortInfo();

                item.Id = countPages;
                context.Posts.Add(item);
                {
                    Post userinfo = new Post();
                    userinfo.Author = item.Author;
                    userinfo.Password = item.Password;
                    userinfo.Description = null; userinfo.Id = item.Id; userinfo.Title = null;
                    user.Add(userinfo);
                }
                // Add to UserList
                {
                    Post userinfo = new Post();
                    userinfo.Author = item.Author;
                    userinfo.Password = null;
                    userinfo.Description = null; userinfo.Id = item.Id; userinfo.Title = item.Title;
                    Posts.Add(userinfo);
                }
                // Add to PostsList
                //data.Add(info);
                countPages++;

                return item;
            }
            else
            {
                return null;
            }
        }


        public Post VerifyUser(Post item)
        {
            if (user.Where(x => x.Author == item.Author).Count() != 0 && user.Where(x => x.Password == item.Password).Count() != 0)
            {
                Post post = user.Where(x => x.Author == item.Author).FirstOrDefault();
                buffer = Get(post.Id);
                return post;
            }
            else {
                return null;
            }
        }
        public void Remove(Post post)
        {
            post = Get(post.Id);
            if (post != null)
            {
                _ = context.Posts.Remove(post);

                {
                    var info = user.First(x => x.Id == post.Id);
                    _ = user.Remove(info);
                }
                
                {
                    var info = Posts.First(x => x.Id == post.Id);
                    _ = Posts.Remove(info);
                }
                //data.Remove(data.Find(x => x.Id == id));
            }
        }
    }
}
