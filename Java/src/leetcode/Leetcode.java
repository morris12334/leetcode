package leetcode;

import java.io.BufferedReader;
import java.io.InputStreamReader;
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

		try {
			String exitCode = "";

			while (exitCode == "") {
				System.out.print("輸入exit離開");
				
				String cmdtxt = cmdList.take();

				String str, ans;
				int num;
				int[] nums, nums1, nums2;
				String[] strs;
				boolean bol;

				switch (cmdtxt) {
				case "Q26":
					System.out.println("26. Remove Duplicates from Sorted Array");
					strs = cmdList.take().split(",");
					nums = Arrays.stream(strs).mapToInt(Integer::parseInt).toArray();
					num = new Q26().removeDuplicates(nums);
					System.out.println("return = "+num);

				case "exit":
				case "e":
					exitCode = "exit";
					break;
				}
			}
		} catch (Exception e) {
			System.out.print(e);
		}

	}

}
