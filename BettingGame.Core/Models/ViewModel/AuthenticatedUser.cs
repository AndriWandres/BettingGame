﻿namespace BettingGame.Core.Models.ViewModel
{
    public class AuthenticatedUser
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
