namespace WebApiFileUpload.Services
{
    public class FileManager : IFile
    {
        public string Upload(IFormFile file)
        {

            if (file.Length > 0)
            {
                if (!Directory.Exists(@"wwwroot\Uploads\"))
                {
                    Directory.CreateDirectory(@"wwwroot\Uploads\");
                }
                string imagesName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                using (FileStream fileStream = System.IO.File.Create(@"wwwroot\Uploads\" + imagesName))
                {

                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return imagesName;
                }

            }
            return null;
        }
    }
}
