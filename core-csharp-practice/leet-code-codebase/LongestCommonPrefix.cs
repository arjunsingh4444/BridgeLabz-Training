public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // Check for null or empty array
        if (strs == null || strs.Length == 0)
            return "";

        // Take first string as prefix
        string prefix = strs[0];

        // Loop through each string
        foreach (string s in strs)
        {
            // Reduce prefix until it matches the start of s
            while (!s.StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If prefix becomes empty
                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}
