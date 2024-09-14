using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.DTO.Disciplines;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly StudentDbContext _dbContext;

        public DisciplineService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddDisciplineAsync(CreateDisciplineDto dto)
        {
            if (await _dbContext.Disciplines.FirstOrDefaultAsync(x => x.Name == dto.Name) != null)
            {
                return false;
            }

            var discipline = new Discipline()
            {
                Name = dto.Name
            };

            await _dbContext.AddAsync(discipline);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<ICollection<Discipline>> GetDisciplinesAsync()
        {
            var disciplines = await _dbContext.Disciplines.ToListAsync();
            return disciplines;
        }

        public async Task<bool> UpdateDisciplineAsync(int id, UpdateDisciplineDto dto)
        {
            var discipline = await _dbContext.Disciplines.FindAsync(id);

            if (discipline == null)
            {
                return false;
            }

            discipline.Name = dto.Name;
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteDisciplineAsync(int id)
        {
            var discipline = await _dbContext.Disciplines.FindAsync(id);

            if (discipline == null)
                return false;

            _dbContext.Disciplines.Remove(discipline);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
