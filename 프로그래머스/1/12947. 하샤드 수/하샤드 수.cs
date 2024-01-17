
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string str = x.ToString();
        int[] number = new int[str.Length];
        int sum = 0;
        for(int i = 0; i < str.Length; i++){
            number[i] = int.Parse(str[i].ToString());
            sum += number[i];
        }
        if (x%sum == 0) answer = true;
        else answer=false;
        return answer;
    }
}