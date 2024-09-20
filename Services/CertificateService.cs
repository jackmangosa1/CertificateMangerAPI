using CertificateMangerAPI.DTO;
using CertificateMangerAPI.Repositories;

namespace CertificateMangerAPI.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;
        public CertificateService(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }
        public async Task CreateCertificate(CertificateDTO certificateDTO)
        {
            await _certificateRepository.CreateCertificate(certificateDTO);
        }

        public async Task<CertificateDTO> GetCertificateById(int certificateId)
        {
            var certificate = await _certificateRepository.GetCertificateById(certificateId);
            return certificate;
        }

        public async Task<IEnumerable<CertificateDTO>> GetAllCertificates()
        {
            var certificates = await _certificateRepository.GetAllCertificates();
            return certificates;
        }

        public async Task DeleteCertificate(int certificateId)
        {
            await _certificateRepository.DeleteCertificate(certificateId);
        }
    }
}
