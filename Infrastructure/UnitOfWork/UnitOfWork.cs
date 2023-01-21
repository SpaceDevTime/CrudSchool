using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            TeacherRepository = new TeacherRepository(_context);
            StudentRepository = new StudentRepository(_context);
            NoteRepository = new NoteRepository(_context);
        }

        public ITeacherRepository TeacherRepository { get; private set; }

        public IStudentRepository StudentRepository { get; private set; }

        public INoteRepository NoteRepository { get; private set; }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
