package solution;

import java.util.Stack;

public class Q402 {
//https://leetcode.com/problems/remove-k-digits/
	public String removeKdigits(String num, int k) {
		int len = num.length();
		if (k == 0)
			return num;
		if (k == len)
			return "0";

		Stack<Character> stack = new Stack<>();
		int index = 0;

		while (index < len) {

			while (k > 0 && !stack.isEmpty() && stack.peek() > num.charAt(index)) {
				stack.pop();
				k--;
			}
			stack.push(num.charAt(index++));
		}
		while (k-- > 0)
			stack.pop();

		StringBuilder result = new StringBuilder();

		while (!stack.isEmpty())
			result.append(stack.pop());

		result.reverse();

		while (result.length() > 1 && result.charAt(0) == '0')
			result.deleteCharAt(0);

		return result.toString();
	}

	private String remove0(String str) {
		if (str.isEmpty())
			return "0";
		else if (str.charAt(0) == '0') {
			return remove0(str.substring(1, str.length()));
		} else
			return str;
	}

	private String stackOverFlowError(String num, int k) {
		int temp = -1;
		String newStr = "";
		if (k > 0) {
			for (int i = 0; i < num.length(); i++) {
				char nowChar = num.toCharArray()[i];
				if (temp <= Integer.valueOf(nowChar)) {
					temp = nowChar;
					newStr += nowChar;

				} else {
					newStr = newStr.substring(0, newStr.length() - 1) + num.substring(i);
					break;
				}
			}
			if (newStr.length() == num.length())
				newStr = num.substring(0, num.length() - 1);
			return removeKdigits(newStr, --k);
		} else {
			while (num.length() > 1 && num.charAt(0) == '0')
				num = num.substring(1);
			if (num.isEmpty())
				return "0";
			return num;
		}
	}
}
