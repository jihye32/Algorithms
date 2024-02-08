using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        Array.Sort(strings);
        answer = strings.OrderBy(str => str[n]).ToArray();
        return answer;
    }
}