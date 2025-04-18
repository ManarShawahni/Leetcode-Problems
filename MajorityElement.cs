using System.Collections.Generic;

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int majorityCount = nums.Length / 2;

        foreach (int num in nums) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }

            if (counts[num] > majorityCount) {
                return num;
            }
        }

        return -1; 
    }
}
