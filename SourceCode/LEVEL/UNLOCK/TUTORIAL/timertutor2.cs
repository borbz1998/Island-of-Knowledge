using UnityEngine;
using System.Collections;

public class timertutor2 : MonoBehaviour {

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
		
		PlayerPrefs.SetInt ("scorePref", 100);
		PlayerPrefs.SetInt ("itemscorePref", 10);

		


	
		PlayerPrefs.SetInt ("TUTORIAL2_score", 1000);
		
		///StartCoroutine (Time ());
	}
}
