public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count=0;

        for(int i=0;i<flowerbed.Length;i++){
            if(flowerbed[i]==0){
                bool solBos =(i==0) || (flowerbed[i-1]==0);
                bool sagBos = (i == flowerbed.Length-1) || (flowerbed[i+1]==0);

                if(solBos && sagBos){
                    flowerbed[i]=1;
                    count++;
                    if(count>=n){
                        return true;
                    }
                }
            }
        }
        return count >= n;
    }
}