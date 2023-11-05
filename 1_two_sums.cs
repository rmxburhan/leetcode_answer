public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            int a = nums[i];
            for (int j = i + 1; j < nums.Length; j++ ) {
                int b = nums[j];
                if ( a + b == target) {
                    return new int[] {i,j};
                }
            }
        }
        return null;
    }   
}
