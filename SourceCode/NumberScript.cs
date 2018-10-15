using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberScript : MonoBehaviour {

	public GameObject StartingPanel;
	public GameObject Platform;
	public GameObject Player;
	public GameObject FinishPanel;

	public GameObject ExampleOne;
	public GameObject ExampleTwo;
	public GameObject ExampleThree;
	public GameObject ExampleFour;
	public GameObject ExampleFive;

    public GameObject onNumber;
    public GameObject OneNumber;
    public GameObject OnesNumber;
    public GameObject OnessNumber;
    public GameObject OnesssNumber;

    public Button O;
	public Button N;
	public Button E;

	public AudioSource Ow;
	public AudioSource En;
	public AudioSource I;

	public AudioSource One;

	public AudioSource SoundOne;
	public AudioSource SoundTwo;
	public AudioSource SoundThree;
	public AudioSource SoundFour;
	public AudioSource SoundFive;

	public Button next;
	public Button nexts;
	public Button nextss;
	public Button nextsss;
	public Button nextssss;
	public Button nextsssss;



	public void StartPanel(){
		StartingPanel.SetActive (false);
		ExampleOne.SetActive (true);
	}
	public void ExampleOnes(){
        ExampleOne.SetActive(false);
        ExampleTwo.SetActive (true);

	}
	public void ExampleTwos(){
		ExampleTwo.SetActive (false);
		ExampleThree.SetActive (true);

	}
	public void ExampleThrees(){
		ExampleThree.SetActive (false);
		ExampleFour.SetActive (true);
	}
	public void ExampleFours(){
		ExampleFour.SetActive (false);
		ExampleFive.SetActive (true);
		next.interactable = true;
	}
	public void ExampleFives(){
        
        ExampleFive.SetActive (false);
		Player.SetActive (true);
		Platform.SetActive (true);
	}
	public void clickO(){
		if (Ow.isPlaying) {
			Ow.Stop ();
		} else {
			Ow.Play();
		}
		O.interactable = false;
		N.interactable = true;
		E.interactable = false;
	}
	public void ClickOne(){
		if (One.isPlaying) {
			One.Stop ();
		} else {
			One.Play();
		}
		next.interactable = true;
	}
	public void ClickN(){
		if (En.isPlaying) {
			Ow.Stop ();
		} else {
			En.Play();
		}
		O.interactable = false;
		N.interactable = false;
		E.interactable = true;
	}
	public void ClickE(){
		if (I.isPlaying) {
			Ow.Stop ();
		} else {
			I.Play();
		}
		O.interactable = true;
		E.interactable = false;
		N.interactable = false;
		nexts.interactable = true;
	}
	public void ClickExampleOneSound(){
        onNumber.SetActive(true);
		if (SoundOne.isPlaying) {
			SoundOne.Stop ();
		} else {
			SoundOne.Play();
		}
		nextss.interactable = true;
	}
	public void ClickExampleTwoSound(){
        OnesNumber.SetActive(true);
        if (SoundTwo.isPlaying) {
			SoundTwo.Stop ();
		} else {
			SoundTwo.Play();
		}

	}
	public void ClickExampleThreeSound(){
        OnessNumber.SetActive(true);
        if (SoundThree.isPlaying) {
			SoundThree.Stop ();
		} else {
			SoundThree.Play();
		}
		nextsss.interactable = true;
	}
	public void ClickExampleFourSound(){
        OnesssNumber.SetActive(true);
        if (SoundFour.isPlaying) {
			SoundFour.Stop ();
		} else {
			SoundFour.Play();
		}
		nextssss.interactable = true;
	}
	public void ClickExampleFiveSound(){
        OneNumber.SetActive(true);

        if (SoundFive.isPlaying) {
			SoundFive.Stop ();
		} else {
			SoundFive.Play();
		}
		nextsssss.interactable = true;
	}

	void Start(){
		Time.timeScale = 1f;

	}
	public void OpenFinishPanel(){
		ExampleFive.SetActive (false);
		Platform.SetActive (true);
		Player.SetActive (true);
	}
	private void OnCollisionEnter2D (Collision2D other)
	{
		
		if (other.gameObject.tag == "Number-Scene") {
			FinishPanel.SetActive (true);
			
		}
	}
}