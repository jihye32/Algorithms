using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";

        for (int i = 1; i < food.Length; i++)
            {
                if (food[i] / 2 != 0)
                {
                    for(int j = 0; j < food[i]/2; j++)
                    {
                        answer += i;
                    }
                }
            }
            char[] Ranswer = answer.ToCharArray();
            Array.Reverse(Ranswer);
            answer += "0";
            for (int i = 0; i < Ranswer.Length; i++)
            {
                answer += Ranswer[i].ToString();
            }
        return answer;
    }
}