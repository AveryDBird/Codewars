using System;
​
public static class Kata
{
  public static int WordsToMarks(string str)
  {
    int intValue =0;
    foreach(char c in str)
      {
        intValue += c - 96;
      }
    return intValue;
  }
}