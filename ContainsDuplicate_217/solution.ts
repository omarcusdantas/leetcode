function containsDuplicate(nums: number[]): boolean {
  const unique = new Set();

  for (const element of nums) {
    if (unique.has(element)) {
      return true;
    }
    unique.add(element);
  }

  return false;
}
