public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sayı = 0;
        for(int i=0;i<k;i++){
            sayı += nums[i];
        }
        int maxSayı = sayı;

        for(int i=k;i<nums.Length;i++){
            sayı = sayı + nums[i]-nums[i-k];
            if(sayı>maxSayı){
                maxSayı = sayı;
            }
        }
        return (double)maxSayı/k;
    }
}