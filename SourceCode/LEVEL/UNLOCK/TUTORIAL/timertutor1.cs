using UnityEngine;
using System.Collections;

public class timertutor1 : MonoBehaviour {

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
		
		PlayerPrefs.SetInt ("scorePref", 100);
		PlayerPrefs.SetInt ("itemscorePref", 10);

		

		PlayerPrefs.SetInt ("TUTORIAL1_score", 1000);
		
		///StartCoroutine (Time ());
	}
}
