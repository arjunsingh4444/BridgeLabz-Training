using System.Collections.Generic;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                st.Push(c);
            else
            {
                if (st.Count == 0) return false;

                char top = st.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                    return false;
            }
        }

        return st.Count == 0;
    }
}
