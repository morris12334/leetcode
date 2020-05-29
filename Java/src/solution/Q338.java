package solution;

public class Q338 {
	// https://leetcode.com/problems/counting-bits/
	public int[] countBits(int num) {
		int[] output = new int[num + 1];

		output[0] = 0;

		for (int i = 1; i <= num; i++) {
			if (i % 2 == 0)
				output[i] = output[i / 2];
			else
				output[i] = output[i - 1] + 1;
		}

		return output;
	}
}
