using Microsoft.EntityFrameworkCore;
using SummerPractice2026Blazor.Repository.Entities;
using SummerPractice2026Blazor.Repository.Interfaces;

namespace SummerPractice2026Blazor.Repository
{
    public class ArticleRepository (ApplicationDbContext dbContext) : IArticleRepository
    {
        public async Task<Article> CreateArticle(Article article)
        {
            dbContext.Articles.Add(article);
            await dbContext.SaveChangesAsync();
            return article;
        }

        public async Task<bool> DeleteArticle(Guid id)
        {
            var articleFromDb = await dbContext.Articles.FirstOrDefaultAsync(x => x.Id == id);
            if (articleFromDb is null)
            {
                return false;
            }

            dbContext.Articles.Remove(articleFromDb);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Article>> GetAllArticles()
        {
            return await dbContext.Articles
                                    .Include(a => a.ArticleCategory)
                                    .ToListAsync();
        }

        public async Task<Article> GetArticleById(Guid id)
        {
            var articleFromDb = await dbContext.Articles.FirstOrDefaultAsync(x => x.Id == id);
            return articleFromDb ?? new Article();
        }

        public async Task<Article> UpdateArticle(Article article)
        {
            dbContext.Articles.Update(article);
            await dbContext.SaveChangesAsync();
            return article;
        }

        public async Task<List<ArticleCategory>> GetAllArticleCategories()
        {
            return await dbContext.ArticleCategories.ToListAsync();
        }
                                    
    }
}
