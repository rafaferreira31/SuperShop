﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imagefile, string folder);
    }
}
