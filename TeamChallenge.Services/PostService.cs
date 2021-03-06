﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamChallange.Models;
using TeamChallenge.Data;

namespace TeamChallenge.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                Author = _userId,
                Title = model.Title,
                Content = model.Content,
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Posts
                    .Where(e => e.Author == _userId)
                    .Select(
                        e => new PostListItem
                        {
                            PostId = e.PostId,
                            Title = e.Title,
                            Content = e.Content,
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
