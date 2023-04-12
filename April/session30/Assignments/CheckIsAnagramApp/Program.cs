namespace CheckIsAnagramApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIsAnagram("heart", "earth"));
        }
        public static bool CheckIsAnagram(string str1, string str2)
        {
            str1 = new string(str1).ToLower();
            str2 = new string(str2).ToLower();

            if (str1.Length != str2.Length)
            {
                return false;
            }

            var str1Chars = str1.ToCharArray();
            Array.Sort(str1Chars);
            var sortedStr1 = new string(str1Chars);

            var str2Chars = str2.ToCharArray();
            Array.Sort(str2Chars);
            var sortedStr2 = new string(str2Chars);

            return sortedStr1 == sortedStr2;
        }

    }
}