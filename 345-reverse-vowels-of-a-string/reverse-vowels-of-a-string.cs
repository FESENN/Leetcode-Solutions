public class Solution {
    public string ReverseVowels(string s) {
        char [] dizi =s.ToCharArray();
        int left = 0;
        int right = s.Length-1;

        while(left<right){

            while(left<right && !IsVowel(dizi[left])){
                left++;
            }

            while(left<right && !IsVowel(dizi[right])){
                right--;
            }

           if (left < right) {
                char temp = dizi[left];
                dizi[left] = dizi[right];
                dizi[right] = temp;

                left++;     // ← BUNLAR EKSİKTİ
                right--;    // ← EKSİK OLDUĞU İÇİN TLE GELİYORDU
            }
        }
        return new string(dizi);
    }
    private bool IsVowel(char c){
        return "aeiouAEIOU".Contains(c);
    }

}