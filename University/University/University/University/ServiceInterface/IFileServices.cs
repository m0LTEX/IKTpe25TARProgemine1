using University.Dto;
using University.Models;

namespace University.ServiceInterface
{
    public interface IFileServices
    {
        public void FilesToApi(CourseDto dto, Course domain);
    

    Task<FileToApi?> RemoveImagFromApi(FileToApiDto dto); 
    }
}
