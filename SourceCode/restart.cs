using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartGame()
	{
		//Time.timeScale = 1f;
		Application.LoadLevel (Application.loadedLevel);
		
	}
	public void RestartNumber()
	{
		//Time.timeScale = 1f;
		Application.LoadLevel (Application.loadedLevel);
		
	}
}
