using UnityEngine;
using System.Collections;

public class timerF : MonoBehaviour {



	public int a ;
	public int b ;
	
	// Use this for initialization
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
		}
		PlayerPrefs.SetInt ("F_score", scores);

		///StartCoroutine (Time ());
	}
	
	// Update is called once per frame


	//IEnumerator Time()
	//{
	//	yield return new WaitForSeconds (2f);
	//	Application.LoadLevel (38);
	//}
}
