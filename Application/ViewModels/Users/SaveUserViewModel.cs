﻿
using System.ComponentModel.DataAnnotations;

namespace EMarketApp.Core.Application.ViewModels.Users
{
    public class SaveUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter your name")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "You must enter your last name")]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "You must enter yout email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "You must enter your phone")]
        [DataType(DataType.Text)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "You must enter your username")]
        [DataType(DataType.Text)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "You must enter your password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "You must confirm your password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The fields password and cofirm pasword are not equals")]
        public string? ConfirmPassword { get; set; }
    }
}
