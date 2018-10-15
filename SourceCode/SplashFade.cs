using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class SplashFade : MonoBehaviour {

	public Image SplashImage;
	public string loadLevel;
	public Text SplashText;
	// Use this for initialization
	IEnumerator Start () {
		SplashImage.canvasRenderer.SetAlpha (0.0f);
		SplashText.canvasRenderer.SetAlpha (0.0f);

		FadeIn ();
		yield return new WaitForSeconds (2.5f);
		FadeOut ();
		yield return new WaitForSeconds (2.5f);
		Application.LoadLevel (loadLevel);
	}
	
	void FadeIn(){
		SplashImage.CrossFadeAlpha (1.0f, 1.5f, false);
		SplashText.CrossFadeAlpha (1.0f, 1.5f, false);
	}
	void FadeOut(){
		SplashImage.CrossFadeAlpha (1.0f, 2.5f, false);
		SplashText.CrossFadeAlpha (1.0f, 2.5f, false);
	}

}
