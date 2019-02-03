using Blog.WebUI.Domain.Entities;
using System.Collections.Generic;
using Bogus;
namespace Blog.WebUI.Infrastructure
{
    public class DataSource
    {
        public List<Article> Articles { get; private set; }
        public List<Comment> Comments { get; private set; }

        public DataSource(int amountArticles = 10, int amountComments = 4) => Seed(amountArticles, amountComments);

        private void Seed(int amountArticles, int amountComments)
        {
            var articleFaker = new Faker<Article>("en")
                .RuleFor(o => o.ArticleId, f => f.IndexVariable)
                .RuleFor(o => o.Author, f => f.Name.FirstName() + " " + f.Name.LastName())
                .RuleFor(o => o.Title, f => f.Lorem.Sentence())
                .RuleFor(o => o.Content, f => f.Lorem.Paragraphs(3));

            var commentFaker = new Faker<Comment>("en")
                .RuleFor(o => o.CommentId, f => f.IndexVariable)
                .RuleFor(o => o.Author, f => f.Name.FirstName() + " " + f.Name.LastName())
                .RuleFor(o => o.DatePublished, f => f.Date.Recent())
                .RuleFor(o => o.Content, f => f.Lorem.Paragraphs(1));

            Articles = articleFaker.Generate(amountArticles);
            Comments = commentFaker.Generate(amountComments);
        }
    }
}
