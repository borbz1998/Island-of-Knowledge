using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timercircle : MonoBehaviour {


	
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
			PlayerPrefs.SetInt ("CIRCLE", 1);
		//	x.SetActive(true);
		}
		PlayerPrefs.SetInt ("CIRCLE_score", scores);
		

	}
}
