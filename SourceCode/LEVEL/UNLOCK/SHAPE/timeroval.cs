using UnityEngine;
using System.Collections;

public class timeroval : MonoBehaviour {

	// Use this for initialization
	public int a ;
	public int b ;
	
	private GameObject x;
	public  int scores; 
	void Start () 
	{
		//x = GameObject.Find("CIRCLE");
		PlayerPrefs.GetInt ("scorePref");
		PlayerPrefs.GetInt ("itemscorePref");
		a = PlayerPrefs.GetInt ("scorePref");
		b = PlayerPrefs.GetInt ("itemscorePref");
		
		scores = a * b;
		
		if (scores >= 600) {
			
			PlayerPrefs.SetInt ("TRIANGLE", 1);
			PlayerPrefs.SetInt ("SQUARE", 1);
			PlayerPrefs.SetInt ("RECTANGLE", 1);
			PlayerPrefs.SetInt ("CIRCLE", 1);
			PlayerPrefs.SetInt ("OVAL", 1);
			PlayerPrefs.SetInt ("HEART", 1);
			//	x.SetActive(true);
		}
		PlayerPrefs.SetInt ("OVAL_score", scores);
		
		///StartCoroutine (Time ());
	}
}
