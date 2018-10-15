using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Settings_sounds : MonoBehaviour {

	public Button b;
	public bool musicMute;
	public Sprite MusicOn;
	public Sprite MusicOff;

	public static int x ;

	// Use this for initialization
	void Start () {



			musicMute = false;
			if (AudioListener.volume == 1) {
				b.image.sprite = MusicOn;
			} 
			else {
			b.image.sprite = MusicOff;
		}
		x = PlayerPrefs.GetInt ("SoundScore");

	}


	
	// Update is called once per frame
	public void MusicAndOff()
	{
		musicMute = !musicMute;
		if (musicMute) {
			AudioListener.volume = 0;
			b.image.sprite = MusicOff;
			PlayerPrefs.SetInt("SoundScore", 0);
		} else if(!musicMute){
			AudioListener.volume = 1;
			b.image.sprite = MusicOn;
			PlayerPrefs.SetInt("SoundScore", 1);
		}
	}


}
