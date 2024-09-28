using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.DTO.Marks;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Services
{
    public class MarkService : IMarkService
    {
        private readonly StudentDbContext _dbContext;

        public MarkService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddMarkAsync(MarkDto dto)
        {
            var student = await _dbContext.Students.FindAsync(dto.StudentId);
            var discipline = await _dbContext.Disciplines.FindAsync(dto.DisciplineId);

            if (student == null || discipline == null)
            {
                return false;
            }

            if (await _dbContext.Marks.FirstOrDefaultAsync(x => x.Student.Id == student.Id && x.DisciplineId == discipline.Id) != null)
            {
                return false;
            }

            var mark = new Mark
            {
                Result = dto.Result,
                StudentId = dto.StudentId,
                DisciplineId = dto.DisciplineId
            };

            await _dbContext.Marks.AddAsync(mark);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateMarkAsync(MarkDto dto)
        {
            //var mark = await _dbContext.Marks.FindAsync(markId);

            //if (mark == null)
            //{
            //    return false;
            //}

            var student = await _dbContext.Students.FindAsync(dto.StudentId);
            var discipline = await _dbContext.Disciplines.FindAsync(dto.DisciplineId);

            if (student == null || discipline == null)
            {
                return false;
            }

            var mark = await _dbContext.Marks.FirstOrDefaultAsync(x => x.StudentId == student.Id && x.DisciplineId == discipline.Id);

            mark.Result = dto.Result;
            mark.StudentId = dto.StudentId;
            mark.DisciplineId = dto.DisciplineId;

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
