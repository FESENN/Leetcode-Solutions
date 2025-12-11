public class Solution {
    public int MaxVowels(string s, int k) {
       HashSet<char> sesli = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

        int sesliHarf = 0;
        for (int i = 0; i<k;i++){
            if( sesli.Contains(s[i])){
                sesliHarf++ ;
            }
        }
        int maxSesli = sesliHarf;
        for (int i = k; i < s.Length; i++){
            if(sesli.Contains(s[i])){
                sesliHarf++;
            }
            if( sesli.Contains(s[i-k]))
            {
                sesliHarf-- ;
            }
            maxSesli = Math.Max(maxSesli,sesliHarf);
            if(maxSesli == k){
                return k;
            }
        }
        return maxSesli ;
    }
}