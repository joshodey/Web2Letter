using WebApplication2.Commands;

namespace WebApplication2.Interface
{
    public interface ILetter
    {
        Task<bool> AddLetter(CreateLetter request);
        void UpdateLetter(CreateLetter request);
        Task<bool> DeleteLetter(string Id);
        Task<List<CreateLetter>> GetAll();
        CreateLetter GetLetterById(string Id);
    }
}
