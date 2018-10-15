using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour {

	public float LoadingTime;
	public Image LoadingBar;
	public Text percent;
	public string LoadLevel;

	void Start ()
	{
		LoadingBar.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (LoadingBar.fillAmount <= 1) {
			LoadingBar.fillAmount += 1.0f / LoadingTime * Time.deltaTime;
		}
		if (LoadingBar.fillAmount == 1.0f) {
			Application.LoadLevel(LoadLevel);
		}
		percent.text = (LoadingBar.fillAmount * 100).ToString ("f0");
	}
}
