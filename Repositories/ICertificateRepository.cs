using CertificateMangerAPI.DTO;

namespace CertificateMangerAPI.Repositories
{
    public interface ICertificateRepository
    {
        Task CreateCertificate(CertificateDTO certificateDTO);
        Task<CertificateDTO> GetCertificateById(int certificateId);
        Task<IEnumerable<CertificateDTO>> GetAllCertificates();
        Task DeleteCertificate(int certificateId);

    }
}
