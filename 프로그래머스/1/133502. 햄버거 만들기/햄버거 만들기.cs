using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                list.Add(ingredient[i]);

                if(list.Count >= 4)
                {
                    if(list[list.Count - 1] == 1 
                        && list[list.Count  - 2] == 3
                        && list[list.Count  - 3] == 2
                        && list[list.Count  - 4] == 1
                        )
                    {
                        list.RemoveRange(list.Count - 4, 4);
                        answer++;
                    }
                }
            }
        return answer;
    }
}