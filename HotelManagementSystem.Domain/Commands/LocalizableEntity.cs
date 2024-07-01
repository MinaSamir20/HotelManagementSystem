using HotelManagementSystem.Domain.Bases;
using System.Globalization;

namespace HotelManagementSystem.Domain.Commands
{
    public class LocalizableEntity : BaseEntity
    {
        public string GetLocalized(string NameEn, string NameAr)
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            if (culture.TwoLetterISOLanguageName.ToLower().Equals("ar"))
                return NameAr;
            return NameEn;
        }
    }
}
