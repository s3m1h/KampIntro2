namespace WebApiFileUpload.Services
{
    public interface IFile
    {
        string Upload(IFormFile formFile);
    }
}
