public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = new List<bool>();
        
        
        int maxCandy = 0;
        foreach (int c in candies) {
            if (c > maxCandy) {
                maxCandy = c;
            }
        }
        
        foreach (int c in candies) {
            if (c + extraCandies >= maxCandy) {
                result.Add(true);
            } else {
                result.Add(false);
            }
        }
        
        return result;
    }
}