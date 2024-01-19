using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long lmoney = money;
        for (int i = 1; i<=count; i++){
            lmoney -= price * i;
        }
        if (lmoney > 0){
            return 0;
        }
        else if(lmoney < 0) return lmoney*(-1);
        else return 0;
    }
}