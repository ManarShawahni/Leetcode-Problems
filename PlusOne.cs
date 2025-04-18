public class Solution {
    public int[] PlusOne(int[] digits) {
        bool carry = true;

        for (int i = digits.Length - 1; i >= 0; i--) {
            if (carry) {
                digits[i]++;
                if (digits[i] == 10) {
                    digits[i] = 0;
                } else {
                    carry = false;
                }
            }
        }

        if (carry) {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            for (int i = 0; i < digits.Length; i++) {
                result[i + 1] = digits[i];
            }
            return result;
        }

        return digits;
    }
}
