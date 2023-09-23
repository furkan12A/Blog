using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Service.Abstractions
{
    public interface lArticleService
    {
        Task<List<ArticleDto>> GetAllArticleAsync();
    }
}
