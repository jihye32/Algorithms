using System.Linq;
using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        string str = n.ToString();
        int[] number = new int[str.Length];
        for(int i = 0; i<str.Length;i++){
            number[i] = int.Parse(str[i].ToString());
        }
        Array.Sort(number);
        Array.Reverse(number);
        str = "";
        for(int i = 0;i<number.Length; i++){
            str += number[i];
        }
        answer = long.Parse(str);
        
        return answer;
    }
}