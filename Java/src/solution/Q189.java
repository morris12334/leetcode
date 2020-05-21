package solution;

public class Q189 {
	public int [] outputArr;
	public Q189(int[] nums, int k) {
		rotate(nums, k);
		outputArr = nums;
	}
	// https://leetcode.com/problems/rotate-array/
	public void rotate(int[] nums, int k) {
		int count = nums.length;
		int[] tmp = new int[count];
		for (int i = 0; i < count; i++) {
			if (i < k)
				tmp[i] = nums[count- k+i];
			else tmp[i] = nums[i-k];
		}
		nums=tmp;		
	}
}
