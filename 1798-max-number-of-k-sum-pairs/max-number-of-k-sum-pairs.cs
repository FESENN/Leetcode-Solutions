public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        
        int left = 0;
        int right = nums.Length - 1;
        int operations = 0;
        
        while (left < right) {
            int sum = nums[left] + nums[right];
            
            if (sum == k) {
                operations++;
                left++;
                right--;
            } 
            else if (sum < k) {
                left++;
            } 
            else {
                right--;
            }
        }
        
        return operations;
    }
    
    public int MaxOperations_HashMap(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int operations = 0;
        
        foreach (int num in nums) {
            int complement = k - num;
        
            if (freq.ContainsKey(complement) && freq[complement] > 0) {
                operations++;
                freq[complement]--;
            } 
            else {
                if (!freq.ContainsKey(num)) {
                    freq[num] = 0;
                }
                freq[num]++;
            }
        }
        
        return operations;
    }
}