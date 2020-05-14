package solution;

import java.util.Arrays;

public class Q540 {
	public int singleNonDuplicate(int[] nums) {
//		if (nums.length <= 9) {
//			int output = 0;
//			for (int i = 0; i < nums.length; i++) {
//				if (i % 2 == 0)
//					output += nums[i];
//				else
//					output -= nums[i];
//			}
//			return Math.abs(output);
//		}

		int mid = (nums.length - 1) / 2;
		try {
			System.out.println(mid + " " + nums[mid - 1] + " " + nums[mid] + " " + nums[mid + 1]);
		} catch (Exception e) {
		}

		if (mid == 0)
			return nums[mid];
		else if (mid % 2 == 0) {
			if (nums[mid] == nums[mid - 1])
				return singleNonDuplicate(Arrays.copyOfRange(nums, 0, mid + 1));
			else if (nums[mid] == nums[mid + 1])
				return singleNonDuplicate(Arrays.copyOfRange(nums, mid, nums.length));
			else
				return nums[mid];
		} else if (mid % 2 == 1) {
			if (nums[mid] == nums[mid - 1])
				return singleNonDuplicate(Arrays.copyOfRange(nums, mid + 1, nums.length));
			else if (nums[mid] == nums[mid + 1])
				return singleNonDuplicate(Arrays.copyOfRange(nums, 0, mid));
			else
				return nums[mid];
		}
		return -1;
	}
}
