using AutoMapper;
using CertificateMangerAPI.Data;
using CertificateMangerAPI.DTO;
using CertificateMangerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CertificateMangerAPI.Repositories
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly CertificateManagerDbContext _context;
        private readonly IMapper _mapper;
        public CertificateRepository(CertificateManagerDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateCertificate(CertificateDTO certificateDTO)
        {
            var certificate = _mapper.Map<Certificate>(certificateDTO);
            await _context.AddAsync(certificate);
            await _context.SaveChangesAsync();
        }

        public async Task<CertificateDTO> GetCertificateById(int certificateId)
        {
            var certificate = await _context.Certificates.FindAsync(certificateId);
            return _mapper.Map<CertificateDTO>(certificate);
        }

        public async Task<IEnumerable<CertificateDTO>> GetAllCertificates()
        {
            var certificates = await _context.Certificates.ToListAsync();
            return _mapper.Map<IEnumerable<CertificateDTO>>(certificates);
        }

        public async Task DeleteCertificate(int certificateId)
        {
            var certificate = await _context.Certificates.FindAsync(certificateId);

            if (certificate == null)
            {
                throw new KeyNotFoundException($"Certificate with ID {certificateId} not found.");
            }
            _context.Certificates.Remove(certificate);
            await _context.SaveChangesAsync();

        }
    }
}
