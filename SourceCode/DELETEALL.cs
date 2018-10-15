using UnityEngine;
using System.Collections;

public class DELETEALL : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	public void Delete()
	{
		PlayerPrefs.SetInt ("scorePref", 0);
		PlayerPrefs.SetInt ("itemscorePref", 0);
	}
	public void DeleteAll()
	{
		PlayerPrefs.DeleteAll ();
	}
}
