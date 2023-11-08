using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<FileResultModel> StoreFile<T>(IFormFile formFile, string subfolder)
        {
            var filename = $"{Guid.NewGuid()}_{formFile.FileName}";
            var pathToFolder = Path.Combine(_webHostEnvironment.WebRootPath, subfolder, typeof(T).Name);
            if (!Directory.Exists(pathToFolder))
            {
                try
                {
                    Directory.CreateDirectory(pathToFolder);
                }
                catch (Exception ex)
                {
                    return new FileResultModel
                    {
                        IsSuccess = false,
                        Error = $"File not stored, please try again later: {ex.Message}"
                    };
                }
            }

            var fullPathToFile = Path.Combine(pathToFolder, filename);
            using (FileStream fileStream = new FileStream(fullPathToFile, FileMode.Create))
            {
                try
                {
                    await formFile.CopyToAsync(fileStream);
                }
                catch (Exception ex)
                {
                    return new FileResultModel
                    {
                        IsSuccess = false,
                        Error = $"File not stored, please try again later: {ex.Message}"
                    };
                }
            }

            return new FileResultModel
            {
                IsSuccess = true,
                FileName = filename,
            };
        }
    }
}
