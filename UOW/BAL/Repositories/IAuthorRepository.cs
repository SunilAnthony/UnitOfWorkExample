using UOW.BAL.Domain;

namespace UOW.BAL.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}