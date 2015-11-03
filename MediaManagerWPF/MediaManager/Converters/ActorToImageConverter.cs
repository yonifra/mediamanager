using System;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WatTmdb.V3;

namespace MediaManager.Converters
{
    public class ActorToImageConverter : IValueConverter
    {
        private Tmdb _api;
        private TmdbConfiguration _tmdbConfig;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            _api = new Tmdb("6f8f5ded34fa534314a23fa7d705681b", "en");
            _tmdbConfig = _api.GetConfiguration();

            var profilePath = value as string;

            return profilePath != null ? GetImageAsync(profilePath) : null;
        }

        public async Task<BitmapImage> GetImageAsync(string profilePath)
        {
            return await Helper.GetImageFromUri(
                        new Uri(_tmdbConfig.images.base_url + _tmdbConfig.images.profile_sizes[0] + profilePath));
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
