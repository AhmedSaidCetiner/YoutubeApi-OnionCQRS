﻿using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException : BaseException
    {
        public ProductTitleMustNotBeSameException() : base("Ürün Başlığı Zaten Var") { }
    }
}
