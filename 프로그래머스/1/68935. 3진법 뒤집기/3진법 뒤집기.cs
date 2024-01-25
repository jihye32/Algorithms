using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> three = new List<int>();
        while (n != 0)
        {
            three.Add(n % 3);
            n = n / 3;
        }
        int index = three.Count - 1;
        answer += three[index];
        for (int i = 0; i < three.Count; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (index - 1 - i < 0) break;
                else
                {
                    three[index -1 - i] *= 3;
                }       
            }
            if (index - 1 - i < 0) break;
            else
            {
                answer += three[index - 1 - i];
            }
        }
        return answer;
    }
}