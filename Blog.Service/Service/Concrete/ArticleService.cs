using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Service.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Service.Concrete
{
    public class ArticleService : lArticleService
    {
        private readonly lUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(lUnitOfWork UnitOfWork , IMapper mapper) 
        {
            unitOfWork = UnitOfWork;
            this.mapper = mapper;
        } 
        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles =    await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);
                return map;
        }
    }
}
