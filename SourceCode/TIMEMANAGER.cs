using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TIMEMANAGER : MonoBehaviour {

	public float startingTime;

	private Text theText;

	public GameObject TimeUPPanel;




	void Start () 
	{

		theText = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	public void Update () 
	{

		startingTime -= Time.deltaTime;

		
		if ( startingTime <= 0) 
		{
			Time.timeScale = 0f;
			TimeUPPanel.SetActive(true);

		}
		theText.text = "" + Mathf.Round (startingTime);

	}

}
