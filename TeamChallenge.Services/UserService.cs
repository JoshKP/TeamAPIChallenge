using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamChallange.Models;
using TeamChallenge.Data;

namespace TeamChallenge.Services
{
    public class UserService
    {
        private readonly SocialMediaUser _userId;
        public UserService(SocialMediaUser userId)
        {
            _userId = userId;
        }

        public bool CreateUser(UserCreate user)
        {
            var entity =
                new SocialMediaUser()
                {
                    Name = user.Name,
                    Email = user.Email,

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.SocialMediaUsers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public IEnumerable<UserListItem> GetSocialMediaUsers()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //                .SocialMediaUsers
        //                .Where(e => e. == _userId)
        //                .Select(
        //                    e =>
        //                        new UserListItem
        //                        {
        //                            Name = e.Name,
        //                            Email = e.Email,
        //                        }
        //                );
        //        return query.ToArray();
        //    }
        //}


    }
}
