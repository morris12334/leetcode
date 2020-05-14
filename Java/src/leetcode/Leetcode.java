package leetcode;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;

import solution.*;

public class Leetcode {

	public static BlockingQueue<String> cmdList = new LinkedBlockingQueue<String>();

	public static void main(String[] args) {
		Thread t = new Thread() {
			public void run() {
				BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
				while (true) {
					try {
						String cmdtxt = reader.readLine();
						cmdList.add(cmdtxt);
						if (cmdtxt.equalsIgnoreCase("exit") || cmdtxt.equalsIgnoreCase("e"))
							break;
					} catch (Exception e) {
						System.out.print(e);
					}
				}
			}
		};
		t.start();

		String exitCode = "";

		while (exitCode == "") {
			try {
				System.out.println("輸入exit離開");

				String cmdtxt = cmdList.take();

				String str, ans;
				int num, num1, num2;
				int[] nums, nums1, nums2;
				int[][] numsArr;
				String[] strs;
				boolean bol;

				switch (cmdtxt) {
				case "exit":
				case "e":
					exitCode = "exit";
					break;

				case "26":
					System.out.println("26. Remove Duplicates from Sorted Array");
					strs = cmdList.take().split(",");
					nums = Arrays.stream(strs).mapToInt(Integer::parseInt).toArray();
					num = new Q26().removeDuplicates(nums);
					System.out.println("return = " + num);
					break;

				case "122":
					System.out.println("122. Best Time to Buy and Sell Stock II");
					strs = cmdList.take().split(",");
					nums = Arrays.stream(strs).mapToInt(Integer::parseInt).toArray();
					num = new Q122().maxProfit(nums);
					System.out.println("return = " + num);
					break;

				case "189":
					System.out.println("189. Rotate Array");
					strs = cmdList.take().split(",");
					num = Integer.valueOf(cmdList.take());
					nums = Arrays.stream(strs).mapToInt(Integer::parseInt).toArray();
					Q189 q189 = new Q189(nums, num);
					System.out.println("return = " + Arrays.toString(q189.outputArr));
					break;

				case "402":
					System.out.println("402. Remove K Digits");
					str = cmdList.take();
					num = Integer.valueOf(cmdList.take());
					str = new Q402().removeKdigits(str, num);
					System.out.println("return = " + str);
					break;

				case "540":
					System.out.println("540. Single Element in a Sorted Array");
					strs = cmdList.take().split(",");
					nums = Arrays.stream(strs).mapToInt(Integer::parseInt).toArray();
					num = new Q540().singleNonDuplicate(nums);
					System.out.println("return = " + num);
					break;

				case "733":
					System.out.println("733. Flood Fill");
					num1 = Integer.valueOf(cmdList.take());
					num2 = Integer.valueOf(cmdList.take());
					num = Integer.valueOf(cmdList.take());
					numsArr = new int[3][];
					numsArr[0] = new int[] { 1, 1, 1 };
					numsArr[1] = new int[] { 1, 1, 0 };
					numsArr[2] = new int[] { 1, 0, 1 };
					numsArr = new Q733().floodFill(numsArr, num1, num2, num);
					System.out.println("return = " + num);
					break;

				case "997":
					System.out.println("997. Find the Town Judge");
					num = Integer.valueOf(cmdList.take());
					numsArr = new int[3][];
					numsArr[0] = new int[] { 1, 3 };
					numsArr[1] = new int[] { 2, 3 };
					numsArr[2] = new int[] { 3, 1 };
					num = new Q997().findJudge(num, numsArr);
					System.out.println("return = " + num);
					break;
				}
			} catch (Exception e) {
				System.out.print(e.fillInStackTrace());
			}
		}

	}

}
