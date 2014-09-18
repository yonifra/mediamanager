using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WatTmdb.V3;

namespace MediaManager.Converters
{
    public class ActorToImageConverter : IValueConverter
    {
        private Tmdb api;
        private TmdbConfiguration tmdbConfig;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            api = new Tmdb("6f8f5ded34fa534314a23fa7d705681b", "en");
            tmdbConfig = api.GetConfiguration();

            var profilePath = value as string;

            if (profilePath != null)
            {
                var image =
                    Helper.GetImageFromUri(
                        new Uri(tmdbConfig.images.base_url + tmdbConfig.images.profile_sizes[0] + profilePath));

                return image;
            }

            return null;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
