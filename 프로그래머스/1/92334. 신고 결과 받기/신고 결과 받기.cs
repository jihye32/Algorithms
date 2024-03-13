using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        report = report.Distinct().ToArray(); //중복 제거
        
        Dictionary<string, int> id = new Dictionary<string, int>();
        //아이디 위치 저장
        for(int i = 0;i< id_list.Length; i++)
        {
            id.Add(id_list[i], i); 
        }
        
        bool[,] rep = new bool[id_list.Length, id_list.Length];
        for(int i =0;i<report.Length;i++)
        {
            string[] s = report[i].Split(' ');
            rep[id[s[0]],id[s[1]]] = true; //신고 받은 위치 true
        }
        
        for(int i = 0; i < id_list.Length; i++)
        {
            int count = 0;
            
            for (int j =0; j<id_list.Length;j++)
            {
                if(rep[j,i])
                {
                    count++;
                }
            }
            
            if(count >= k){
                for(int j =0; j<id_list.Length; j++)
                {
                    if (rep[j,i])
                    {
                        answer[j]++;
                    }
                }
            }
        }
        
        
        return answer;
    }
}