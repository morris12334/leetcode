package solution;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Q438 {
	public List<Integer> outputList;

	public Q438(String s, String p) {
		outputList = findAnagrams(s, p);
	}

	public List<Integer> findAnagrams(String s, String p) {
		int[] charArray = new int[123];
		for (char c : p.toCharArray()) {
			charArray[c]++;
		}

		List<Integer> ans = new ArrayList<Integer>();

		for (int i = 0; i <= s.length() - p.length(); i++) {
			int[] copy_Array = charArray.clone();
			ans.add(i);
			for (int j = i; j < p.length() + i; j++) {
				if (--copy_Array[s.charAt(j)] < 0) {
					ans.remove(ans.size() - 1);
					break;
				}
			}
		}
		return ans;
	}

}
