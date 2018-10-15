using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {



	// Use this for initialization

	public static int playerscore;
	public static int itemscore;
	//private int score; 
	//public Text TIMETXT;
	//public Text ITEMTXT;
	public int scores ;
	public int a ;
	public int b ;



	void Start () 
	{

		PlayerPrefs.GetInt ("scorePref");
		PlayerPrefs.GetInt ("itemscorePref");
		a = PlayerPrefs.GetInt ("scorePref");
		b = PlayerPrefs.GetInt ("itemscorePref");

		scores = a * b;

		if (scores >= 600) {
			PlayerPrefs.SetInt ("A", 1);
			PlayerPrefs.SetInt ("B", 1);
		}
		PlayerPrefs.SetInt ("A_score", scores);

		///StartCoroutine (Time ());
	}


	// Update is called once per frame


	//IEnumerator Time()
	//{
	//	yield return new WaitForSeconds (2f);
	//	Application.LoadLevel (38);
	//}
}
