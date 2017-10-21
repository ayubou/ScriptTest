using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	public class Boss {
		
		//int型の変数mpを宣言し、53で初期化してください
		private int mp = 53;

		//mpを消費して魔法攻撃をするMagic関数を作ってください
		public  void Magic(int damage) { 
			this.mp -= damage;
			if (mp <= 0) {
				Debug.Log ("MPが足りないため魔法が使えない。");
			} else {
				Debug.Log ("魔法攻撃をした。残りMPは" + mp);
			}
		}

	}


	void Start () {

		//素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] array = {1,2,3,4,5};

		//配列の各要素の値を順番に表示してください
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//for文を使い、配列の各要素の値を逆順に表示してください
		for (int i = array.Length-1; 0 <= i; i--) {
			Debug.Log (array [i]);
		}

		//Magic関数を呼び出して、魔法を使ってください
		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、
		//mpが足りないメッセージが表示されることを確認してください
		Boss lastboss = new Boss ();

		for (int i = 0; i < 11; i++) {
			lastboss.Magic(5);
		}
	}


	void Update () {
		
	}
}
