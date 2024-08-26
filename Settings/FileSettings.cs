using GameZone.Models;
using static System.Net.Mime.MediaTypeNames;

namespace GameZone.Settings
{
    public static class FileSettings
    {
        public const string ImagesPath = "/assets/Images/Games";

        public const string AllowExtensions = ".jpg,.jpeg,.png";
        public const int MaxFileSizeInMB = 1;
        public const int MaxFileSizeInByte = MaxFileSizeInMB * 1024 * 1024;

    }
}
