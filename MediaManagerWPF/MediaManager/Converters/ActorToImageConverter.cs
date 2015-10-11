using System;
using System.Windows.Data;
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

            if (profilePath != null)
            {
                var image =
                    Helper.GetImageFromUri(
                        new Uri(_tmdbConfig.images.base_url + _tmdbConfig.images.profile_sizes[0] + profilePath));

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
