package solution;


public class Q886 {
	//https://leetcode.com/problems/possible-bipartition/
	public boolean possibleBipartition(int N, int[][] dislikes) {
        int[][] G = new int[N][N];
        for (int[] d : dislikes) {
            int i = d[0]-1, j = d[1]-1;
            G[i][j] = G[j][i] = 1;
        }
        for (int i = 0; i < N; i++) {
            if (G[i][i] != 0) continue;
            if (!dfs(G, 2, i)) return false;
        }
        return true;
    }
            
    private boolean dfs(int[][] G, int color, int i) {        
        G[i][i] = color;
        for (int j = 0; j < G.length; j++) {
            if (i == j) continue;
            if (G[i][j] == 0) continue; // no relationship
            if (G[j][j] == -color) continue; // adjacent node is painted properly
            if (G[j][j] == color) return false;  // adjacent node is pained wrongly
            if (!dfs(G, -color, j)) return false;
        }
        return true;
    }

}
