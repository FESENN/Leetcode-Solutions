public class Solution {
    public string MergeAlternately(string word1, string word2) 
    {
        
        var merge = new System.Text.StringBuilder();
        int i = 0;
        for (i=0;i<word1.Length || i<word2.Length;i++)
        {
            if(i<word1.Length)
            {
                merge.Append(word1[i]);
            }
            if(i<word2.Length)
            {
                merge.Append(word2[i]);
            }
        }
        return merge.ToString();
    }
}