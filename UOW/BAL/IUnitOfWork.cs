using UOW.BAL.Repositories;
using System;

namespace UOW.BAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}