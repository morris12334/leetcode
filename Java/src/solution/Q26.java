package solution;

public class Q26 {
	//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
	public int removeDuplicates(int[] nums) {
		int num = nums.length;
		int j = 0;
		for (int i = 0; i < num; i++) {
			if (nums[i] != nums[j])
				nums[++j] = nums[i];
		}
		return j + 1;
	}
}
