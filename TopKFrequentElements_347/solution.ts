function topKFrequent(nums: number[], k: number): number[] {
  const frequencies = new Map();

  for (const num of nums) {
    const count = frequencies.get(num)?? 0;
    frequencies.set(num, count + 1);
  }

  const sortedFrequencies = Array.from(frequencies.entries()).sort((a, b) => b[1] - a[1]);
  return sortedFrequencies.slice(0, k).map((entry) => entry[0]);
}
