function isAnagram(s: string, t: string): boolean {
  if (s.length !== t.length) return false;

  const hashS = new Map<string, number>();
  const hashT = new Map<string, number>();

  for (let i = 0; i < s.length; i++) {
    const countS = hashS.get(s[i]) || 0;
    hashS.set(s[i], countS + 1);

    const countT = hashT.get(t[i]) || 0;
    hashT.set(t[i], countT + 1);
  }

  for (const key of hashS.keys()) {
    if (hashS.get(key) !== hashT.get(key)) return false;
  }

  return true;
}

function isAnagram2(s: string, t: string): boolean {
  if (s.length !== t.length) return false;

  const sortedS = [...s].sort().join("");
  const sortedT = [...t].sort().join("");

  return sortedS === sortedT;
}
