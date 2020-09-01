using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using TeamChallange.Models;
using TeamChallenge.Services;

namespace TeamChallenge.Controllers
{
    [Authorize]
    public class PostController : ApiController
    {
        private readonly SocialMediaUser _userId;

        public IHttpActionResult Get()
        {
            PostService postService = CreatePostService();
            var posts = postService.GetPosts();
            return Ok(posts);
        }
        public IHttpActionResult Get(int id)
        {
            PostService postService = CreatePostService();
            var post = postService.GetPostById(id);
            return Ok(post);
        }
        public IHttpActionResult Post(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePostService();

            if (!service.CreatePost(post))
                return InternalServerError();

            return Ok();
        }

        private PostService CreatePostService()
        {
            // var userId = User.Identity.GetUserId();
            var postService = new PostService(_userId);
            return postService;
        }
    }
}
