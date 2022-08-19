namespace RandomDudeAPI.Methods
{
    public class PersonContact
    {
        private static string[] domens =
        {
            "yandex.ru",
            "narod.ru",
            "ya.ru",
            "yandex.com",
            "yandex.ua",
            "yandex.kz",
            "yandex.by",
            "mail.ru",
            "list.ru",
            "inbox.ru",
            "bk.ru",
            "gmail.com",
            "yahoo.com",
            "outlook.com"
        };
        public static string GetEmail(string surname) => Translate(surname.ToLower()) + $"{(Random.Shared.Next(2) == 1 ? '_' : string.Empty)}" + Random.Shared.Next(1, 10000) + "@" + domens[Random.Shared.Next(domens.Length)];

        public static string GetPhone() => "+79" + Random.Shared.Next(10, 99) + Random.Shared.Next(1000000, 9999999);

        private static string Translate(string s)
        {
            string result = "";
            string[] rus = {"а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я"};
            string[] eng = {"a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n","o","p","r","s","t","u","f","kh","ts","ch","sh","shch",null,"y",null,"e","yu","ya"};

            for (int j = 0; j < s.Length; j++)
                for (int i = 0; i < rus.Length; i++)
                    if (s.Substring(j, 1) == rus[i]) 
                        result += eng[i];

            return result;
        }
    }
}
