public class LastWordLength
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Trim().Split(' ');
        return words[words.Length - 1].Length;
    }
}
