using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Repository.Interfaces;
public interface IArticleCategoryRepository
{
    Task<ArticleCategory> CreateArticleCategory(ArticleCategory articleCategory);

    Task<bool> DeleteArticleCategory(Guid id);

    Task<List<ArticleCategory>> GetAllArticleCategory();

    Task<ArticleCategory> UpdateArticleCategory(ArticleCategory articleCategory);

    Task<ArticleCategory> GetArticleCategoryById(Guid id);
}