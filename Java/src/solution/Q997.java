package solution;

public class Q997 {
//https://leetcode.com/problems/find-the-town-judge/

	public int findJudge(int N, int[][] trust) {
		int[] Arr = new int[N + 1];
		for (int[] e : trust) {
			Arr[e[1]]++;
			Arr[e[0]]--;
		}
		for (int i = 1; i < N + 1; i++) {
			if (Arr[i] == N - 1) {
				return i;
			}
		}
		return -1;
	}
}
