
namespace ConsoleApp1
{
    public class Question03
    {
        public string nthCase(int n, string message)
        {
            if (n <= 0)
                return message;

            if (string.IsNullOrEmpty(message))
                return string.Empty;

            string answer = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (i % n == 0)
                {
                    answer += message[i].ToString().ToUpper();
                }

                answer += message[i];
            }

            return answer;
        }
    }
}
