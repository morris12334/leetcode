package solution;

import java.util.ArrayList;

public class Q208 {
	/* Initialize your data structure here. */
	public Q208() {
	}

	ArrayList<String> arr = new ArrayList<String>();

	/* Inserts a word into the trie. */
	public void insert(String word) {
		arr.add(word);
	}

	/* Returns if the word is in the trie. */
	public boolean search(String word) {
		return arr.contains(word);
	}

    /* Returns if there is any word in the trie that starts with the given prefix. */
	public boolean startsWith(String prefix) {
		return arr.stream().anyMatch(s->s.startsWith(prefix));
	}
}
