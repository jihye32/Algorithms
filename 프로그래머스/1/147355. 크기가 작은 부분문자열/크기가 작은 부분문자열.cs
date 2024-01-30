using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        string str = "";
        char[] ch = t.ToCharArray();
        for(int i =0; i<= t.Length - p.Length; i++){
            for(int j=i; j<p.Length+i;j++){
                str += ch[j];
            }
            long t1 = long.Parse(str);
            long p1 = long.Parse(p);
            answer += (t1<=p1) ? 1:0;
            str = "";
        }
        return answer;
    }
}