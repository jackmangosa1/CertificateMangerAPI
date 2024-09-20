using CertificateMangerAPI.DTO;

namespace CertificateMangerAPI.Services
{
    public interface ICertificateService
    {
        Task CreateCertificate(CertificateDTO certificateDTO);
        Task<CertificateDTO> GetCertificateById(int certificateId);
        Task<IEnumerable<CertificateDTO>> GetAllCertificates();
        Task DeleteCertificate(int certificateId);
    }
}
