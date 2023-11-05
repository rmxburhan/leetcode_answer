public class Solution {
    public int Reverse(int x) {
        try {
            string temp = "";
            string xString = x.ToString();
            if (xString[0] == '-') {
                temp = "-";
                xString = xString.Substring(1, xString.Length - 1);
            }
            for (int i =  xString.Length - 1; i >= 0; i-- ) {
                temp += xString[i];
            }
            Console.WriteLine(temp);
            return int.Parse(temp);
        } catch (Exception ex) {
            return 0;
        }
       
    }
}

public class Solution {
    public int Reverse(int x) {
        string xString = x.ToString();
        string result = "";
        if (xString[0] == '-') {
            result = "-";
            xString = xString.Substring(1, xString.Length - 1);
        } 

        char[] xChar = xString.ToCharArray();
        Array.Reverse(xChar);
        result += string.Join("", xChar);

        if (int.TryParse(result, out int a)) {
            return a;
        } else {
            return 0;
        }
    }
} 
