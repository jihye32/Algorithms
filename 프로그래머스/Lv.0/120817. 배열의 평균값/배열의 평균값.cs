using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        double result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }
        answer = result / numbers.Length;
        return answer;
    }
}