﻿using Shrooms.EntityModels.Models;

namespace Shrooms.DataTransferObjects.Models.WallPosts
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public decimal TotalKudos { get; set; }
        public string PictureId { get; set; }
        public string Email { get; set; }

        public UserDto(ApplicationUser user)
        {
            Id = user.Id;
            FullName = user.FirstName + ' ' + user.LastName;
            UserName = user.UserName;
            TotalKudos = user.TotalKudos;
            PictureId = user.PictureId;
            Email = user.Email;
        }
    }
}