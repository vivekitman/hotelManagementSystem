using System;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.IRepository;

namespace WebApplication1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DetaBaseCountext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotelcs> _hotels;

        public UnitOfWork(DetaBaseCountext context)
        {
            _context = context;    
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenrcRepository<Country>(_context);
        public IGenericRepository<Hotelcs> Hotels => _hotels ??= new GenrcRepository<Hotelcs>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
