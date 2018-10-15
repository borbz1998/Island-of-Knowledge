using UnityEngine;
using System.Collections;

public class timerorange : MonoBehaviour {

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
			
			PlayerPrefs.SetInt ("RED", 1);
			PlayerPrefs.SetInt ("YELLOW", 1);
			PlayerPrefs.SetInt ("ORANGE", 1);
			PlayerPrefs.SetInt ("BLUE", 1);
		}
		PlayerPrefs.SetInt ("ORANGE_score", scores);
		///StartCoroutine (Time ());
	}

}
