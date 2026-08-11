namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
          sentence = sentence.ToLower();
          sentence = sentence.Replace(" ", "");
          if (sentence.Contains("english"))
            {
            return true;
            }
          else
          {
            return false;
          }
        }
    }
}