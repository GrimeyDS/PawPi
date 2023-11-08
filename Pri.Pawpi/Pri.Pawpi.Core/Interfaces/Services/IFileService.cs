using Microsoft.AspNetCore.Http;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IFileService
    {
        Task<FileResultModel> StoreFile<T>(IFormFile formFile, string subfolder);
    }
}
