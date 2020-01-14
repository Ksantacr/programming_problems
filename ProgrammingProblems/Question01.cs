
namespace ConsoleApp1
{
    public class Question01
    {
        public string encrypt(string key, string message)
        {
            if (string.IsNullOrEmpty((message)))
                return "";

            if (string.IsNullOrEmpty((key)))
                key = "DCJ ";
            string encryptedMEssage = "";
            string vowels = "aeiouAEIOU";
            foreach (var letter in message)
            {
                if (vowels.IndexOf(letter) >= 0)
                {
                    encryptedMEssage += key + letter;
                }
                else
                {
                    encryptedMEssage += letter;
                }
            }

            return encryptedMEssage;
        }
    }
}
