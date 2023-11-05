public class Solution {
    public int GetWinner(int[] arr, int k) {
        var list = arr.ToList();
        int increment = 0;
        var data = -1;
        while(true) {
            if (list[1] > list[0]) {
                list.Add(list[0]);
                list.RemoveAt(0);
                data = list[1];
                if (data != list[1]) {
                    increment = 0;
                }
            } else {
                list.Add(list[1]);
                list.RemoveAt(1);
                data = list[0];
                if (data != list[0]) {
                    increment = 0;
                }
            }
            increment++;
            if (increment ==k && data != -1) {
                return data;
            }
        }
    }

}
