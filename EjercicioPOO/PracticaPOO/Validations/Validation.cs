using System.Text.RegularExpressions;

namespace Validations
{
    public class Validation
    {
        public static bool ValidateISBN(string isbn)
        {
            if (isbn is not null)
            {
                char [] charsInISBN = isbn.ToCharArray();
                if (charsInISBN.Length > 11 || charsInISBN[9] != '-')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidateAuthor(string author)
        {
            Regex validName = new Regex(@"^([A-Za-zÁÉÍÓÚñáéíóúÑ\.]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'\.]+[\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ\.]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'\.])+[\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ\.]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'\.])?$");
            if (validName.IsMatch(author))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateTitle(string title)
        {
            Regex validName = new Regex(@"^([A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-\']+[\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-\'])+[\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ0-9\-\'])?$");
            if (validName.IsMatch(title))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateNumberOfPages(string numberOfPages)
        {
            int result = 0;
            if (int.TryParse(numberOfPages, out result))
            {
                return true;
            }
            return false;
        }
    }
}