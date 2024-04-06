public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if( c == '(') 
            {
                stack.Push(')'); 
                continue;
            }

            if( c == '{') 
            { 
                stack.Push('}'); 
                continue;
            }

            if( c == '[') 
            { 
                stack.Push(']'); 
                continue;
            }

            if(stack.Count == 0 || c != stack.Pop()) return false;
        }
    
        return stack.Count == 0;
    }
}