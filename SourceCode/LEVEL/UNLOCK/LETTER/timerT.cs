using UnityEngine;
using System.Collections;

public class timerT : MonoBehaviour {

	// Use this for initialization
	public int a ;
	public int b ;
	
	public  int scores; 
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
			PlayerPrefs.SetInt ("C", 1);
			PlayerPrefs.SetInt ("D", 1);
			PlayerPrefs.SetInt ("E", 1);
			PlayerPrefs.SetInt ("F", 1);
			PlayerPrefs.SetInt ("G", 1);
			PlayerPrefs.SetInt ("H", 1);
			PlayerPrefs.SetInt ("I", 1);
			PlayerPrefs.SetInt ("J", 1);
			PlayerPrefs.SetInt ("K", 1);
			PlayerPrefs.SetInt ("L", 1);
			PlayerPrefs.SetInt ("M", 1);
			PlayerPrefs.SetInt ("N", 1);
			PlayerPrefs.SetInt ("O", 1);
			PlayerPrefs.SetInt ("P", 1);
			PlayerPrefs.SetInt ("Q", 1);
			PlayerPrefs.SetInt ("R", 1);
			PlayerPrefs.SetInt ("S", 1);
			PlayerPrefs.SetInt ("T", 1);
			PlayerPrefs.SetInt ("U", 1);
		}
		PlayerPrefs.SetInt ("T_score", scores);
		
		///StartCoroutine (Time ());
	}
}
