using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatform();
        Platform GetPlatformById(int id);

        void CreatePlatform(Platform platform);
    }
}