public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n];
        k = k % n;

        for (int i = 0; i < n; i++) {
            int newIndex = (i + k) % n;
            result[newIndex] = nums[i];
        }

        for (int i = 0; i < n; i++) {
            nums[i] = result[i];
        }
    }
}
