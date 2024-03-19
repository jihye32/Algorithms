using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int addValue = (brown / 2) + 2;
            int xy = brown + yellow; // 가로 * 세로
            int y = 0, x = 0;

            for (y = 3; y <= addValue / 2; y++)
            {
                x = addValue - y;

                if (xy == x * y)
                    break;
            }

            return new int[2] { x, y };
    }
}