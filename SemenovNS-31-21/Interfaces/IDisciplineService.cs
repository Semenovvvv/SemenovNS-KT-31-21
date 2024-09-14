using SemenovNS_31_21.DTO.Disciplines;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Interfaces
{
    public interface IDisciplineService
    {
        public Task<bool> AddDisciplineAsync(CreateDisciplineDto dto);
        public Task<ICollection<Discipline>> GetDisciplinesAsync();
        public Task<bool> UpdateDisciplineAsync(int id, UpdateDisciplineDto dto);
        public Task<bool> DeleteDisciplineAsync(int id);
    }
}
