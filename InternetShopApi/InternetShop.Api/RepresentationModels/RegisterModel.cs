﻿namespace InternetShop.Api.RepresentationModels
{
    public class RegisterModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string secretKey { get; set; }
    }
}