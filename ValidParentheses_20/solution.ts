function isValid(s: string): boolean {
    const stack: string[] = [];
    
    for (const char of s) {
      if (char === '(') {
        stack.push(')');
        continue;
      }
      
      if (char === '{') {
        stack.push('}');
        continue;
      } 
      
      if (char === '[') {
        stack.push(']');
        continue;
      } 
      
      if (stack.length === 0 || char !== stack.pop()) {
        return false;
      }
    }

    return stack.length === 0;
}