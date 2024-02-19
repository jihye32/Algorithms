using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int count =0;
        int sum =0;
        for (int i = 0; i < nums.Length-2; i++){
            for(int j = i+1;j<nums.Length-1;j++){
                for(int l = j+1;l<nums.Length;l++){
                    sum = nums[i]+nums[j]+nums[l];
                    for (int x = 2; x < sum; x++){
                        
                        if (sum%x == 0){
                            break;
                        }
                        else{
                            answer = x;
                        }
                    }
                    if(answer == sum-1){
                        count ++;
                    }
                }
            }
        }
        return count;
    }
}