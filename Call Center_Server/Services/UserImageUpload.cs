using Call_Center_Server.Services.IServices;

using Microsoft.AspNetCore.Components.Forms;

namespace Call_Center_Server.Services
{
    public class UserImageUpload : IUserImageUpload
    {
        private const string defaultUserImage = "/images/users/default-user-icon.jpg";
        private readonly IWebHostEnvironment webHostEnvironment;

        public UserImageUpload(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string filePath)
        {
            if (File.Exists(webHostEnvironment.WebRootPath + filePath) && !filePath.Equals(defaultUserImage))
            {
                File.Delete(webHostEnvironment.WebRootPath + filePath);
                return true;
            }
            return false;
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            string fullPath = string.Empty;
            if (file != null)
            {
                //Rename the file.

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                //Check & create the directory of upload file.
                var folderDirectory = $"{webHostEnvironment.WebRootPath}\\images\\users";
                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                //Read file then upload it.
                var filePath = Path.Combine(folderDirectory, fileName);
                await using FileStream fs = new FileStream(filePath, FileMode.Create);
                await file.OpenReadStream().CopyToAsync(fs);

                //Return the new path of upload file.
                 fullPath = $"/images/users/{fileName}";               
            }
            else
            {
                fullPath = defaultUserImage;
            }
            return fullPath;
        }
    }
}
