using SemenovNS_31_21.DTO.Marks;

namespace SemenovNS_31_21.Interfaces
{
    public interface IMarkService
    {
        public Task<bool> AddMarkAsync(MarkDto dto);
        public Task<bool> UpdateMarkAsync(MarkDto dto);
    }
}
