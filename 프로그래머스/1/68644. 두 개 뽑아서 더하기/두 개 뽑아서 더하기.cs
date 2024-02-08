using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> n = new List<int>();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                n.Add( numbers[i] + numbers[j]);
            }
        }
        answer = n.Distinct().ToArray();
        Array.Sort(answer);

        return answer;
    }
}