public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        string[] week = {"THU","FRI","SAT","SUN","MON","TUE","WED"};
        int[] month = {0,31,29,31,30,31,30,31,31,30,31,30};
        int date = 0;
        for(int i =0;i<a;i++){
            date += month[i];
        }
        answer = week[(date + b)%7];
        
        return answer;
    }
}