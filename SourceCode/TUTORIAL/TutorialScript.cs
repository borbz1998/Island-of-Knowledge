using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {

	public GameObject UpPanel;
	public GameObject DownPanel;
	public GameObject JumpPanel;
	public GameObject SlidePanel;
	public GameObject HeartPanel;
	public GameObject TimePanel;
	public GameObject ObjectPanel;

	public AudioSource UPSound;
	public AudioSource DownSound;
	public AudioSource JumpSound;
	public AudioSource SlideSound;
	public AudioSource HeartSound;
	public AudioSource TimeSound;
	public AudioSource ObjectSound;

	public void UP(){
		UPSound.Stop ();
		UpPanel.SetActive (false);
		DownPanel.SetActive (true);
		DownSound.Play ();
	}
	public void Down(){
		DownSound.Stop ();
		DownPanel.SetActive (false);
		JumpPanel.SetActive (true);
		JumpSound.Play ();
	}
	public void Jump(){
		JumpSound.Stop ();
		JumpPanel.SetActive(false);
		SlidePanel.SetActive (true);
		SlideSound.Play ();
	}
	public void Slide(){
		SlideSound.Stop ();
		SlidePanel.SetActive (false);
		HeartPanel.SetActive (true);
		HeartSound.Play ();
	}
	public void Heart(){
		HeartSound.Stop ();
		HeartPanel.SetActive (false);
		TimePanel.SetActive (true);
		TimeSound.Play ();
	}
	public void Time(){
		TimeSound.Stop ();
		TimePanel.SetActive (false);
		ObjectPanel.SetActive (true);
		ObjectSound.Play ();
	}
	public void Objects(){
		ObjectSound.Stop ();
		ObjectPanel.SetActive (false);
		Application.LoadLevel ("LETTERMENU");
	}

}
