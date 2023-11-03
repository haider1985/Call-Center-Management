using Microsoft.AspNetCore.Components.Forms;

namespace Call_Center_Server.Services.IServices
{
    public interface IUserImageUpload
    {
        Task<string> UploadFileAsync(IFormFile file);
        bool DeleteFile(string filePath);
    }
}
