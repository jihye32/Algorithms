using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char[] ch = s.ToCharArray();
        int check;
        string str = "";
        for (int i = 0; i < ch.Length; i++)
        {
        if (int.TryParse(ch[i].ToString(), out check))
        {
            str += check.ToString();
        }
        else
        {
            switch (ch[i].ToString())
            {
                case "z":
                    str += "0";
                    i += 3;
                    break;
                case "o":
                    str += "1";
                    i += 2;
                    break;
                case "t":
                    if (ch[i + 1].ToString() == "w")
                    {
                        str += "2";
                        i += 2;
                    }

                    else if (ch[i + 1].ToString() == "h")
                    {
                        str += "3";
                        i += 4;
                    }
                    break;
                case "f":
                    if (ch[i + 1].ToString() == "o")
                    {
                        str += "4";
                        i += 3;
                    }
                    else if (ch[i + 1].ToString() == "i") 
                    {
                        str += "5";
                        i += 3;
                    }
                    break;
                case "s":
                    if (ch[i + 1].ToString() == "i")
                    {
                        str += "6";
                        i += 2;
                    }

                    else if (ch[i + 1].ToString() == "e")
                    {
                        str += "7";
                        i += 4;
                    }
                    break;
                case "e":
                    str += "8";
                    i += 4;
                    break;
                case "n":
                    str += "9";
                    i += 3;
                    break;
                default:
                    break;
            }
        
        }
        }
        answer = int.Parse(str);
        return answer;
    }
}