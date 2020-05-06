package solution;

public class Q122 {
	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
	public int maxProfit(int[] prices) {
		int num = prices.length;
		int nowProfit=0;
		for (int i = 1; i < num; i++) {
			int dayProfit = prices[i]-prices[i-1];
			if( dayProfit>0) {
				nowProfit +=dayProfit;
			}
		}
		return nowProfit;
		
	}
}
