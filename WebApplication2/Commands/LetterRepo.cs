using Microsoft.EntityFrameworkCore;
using WebApplication2.Context;
using WebApplication2.Interface;
using WebApplication2.Models;

namespace WebApplication2.Commands
{
    public class LetterRepo : ILetter
    {
        readonly ApplicationDbContext _context;

        public LetterRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> AddLetter(CreateLetter request)
        {
            var data = new Letter()
            {
                Id = Guid.NewGuid().ToString(),
                AgencyId = request.AgencyId,
                UserId = request.UserId,
                CreatedDate = DateTime.Now,
                dateRecieved = DateTime.Now,
                Status = 1,
                CaseTrackingGuid = Guid.NewGuid().ToString(),
                supportingDocument = request.supportingDocument
            };

            _context.letters.Add(data);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
        public void UpdateLetter(CreateLetter request)
        {
            var data = _context.letters.FirstOrDefault(x => x.Id == request.Id);
            data.letter = request.letter;
            data.letterstatus = request.letterstatus;
            data.supportingDocument = request.supportingDocument;
            data.supportingDocuments = request.supportingDocuments;
            data.dateRecieved = request.dateRecieved;
            data.AgencyId = request.AgencyId;
            data.CaseTrackingGuid = request.CaseTrackingGuid;
            data.CreatedDate = request.CreatedDate;

            _context.letters.Update(data);
            _context.SaveChanges();


        }

        public async Task<bool> DeleteLetter(string Id)
        {
            var res = await _context.letters.FirstOrDefaultAsync(x => x.Id == Id);

            if (res == null)
                return false;

            _context.letters.Remove(res);
            _context.SaveChanges();

            return await Task.FromResult(true);
        }

        public async Task<List<CreateLetter>> GetAll()
        {
            var data = await _context.letters.Select(x => new CreateLetter()
            {
                Name = x.Name,
                dateRecieved = x.dateRecieved,
                CreatedDate = x.CreatedDate,
                supportingDocument = x.supportingDocument,
                AgencyId = x.AgencyId,
                CaseTrackingGuid = x.CaseTrackingGuid,
                Id = x.Id,
                supportingDocuments = x.supportingDocuments,
                regionId = x.regionId,
                Status = x.Status,
                UserId = x.UserId,
                letter = x.letter,
                letterstatus = x.letterstatus,
                referenceNumber = x.referenceNumber
            }).ToListAsync();

            return data;
        }


        public CreateLetter GetLetterById(string Id)
        {
            var data =  _context.letters.FirstOrDefault(x => x.Id == Id);

            return new CreateLetter()
            {
                Id = data.Id,
                dateRecieved = data.dateRecieved,
                CreatedDate = data.CreatedDate,
                supportingDocument = data.supportingDocument,
                supportingDocuments = data.supportingDocuments,
                AgencyId = data.AgencyId,
                Status = data.Status,
                CaseTrackingGuid = data.CaseTrackingGuid,
                letter = data.letter,
                letterstatus = data.letterstatus,
                Name = data.Name
            };
        }

    }
}
