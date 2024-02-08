using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] arrays = new int[commands[i, 1] - commands[i, 0] + 1];
                for (int j = 0; j < commands[i, 1] - commands[i, 0] + 1; j++)
                {
                    arrays[j] = array[commands[i, 0] - 1 + j];
                }
                Array.Sort(arrays);
                answer[i] = arrays[commands[i,2] - 1];
            }
        return answer;
    }
}