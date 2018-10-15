using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberFour : MonoBehaviour
{

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

    public Button T;
    public Button H;
    public Button R;

    public Button E;
    public Button EE;



    public AudioSource Ti;
    public AudioSource eytch;
    public AudioSource ar;
    public AudioSource i;
    public AudioSource ee;

    public AudioSource One;

    public AudioSource SoundOne;
    public AudioSource SoundTwo;
    public AudioSource SoundThree;
    public AudioSource SoundFour;
    public AudioSource SoundFive;

    //birds
    public Button onebird;
    public GameObject OneBird;
    public Button twoBirds;
    public GameObject twosBirds;

    //cars
    public Button onecar;
    public GameObject OneCar;
    public Button TwoCars;
    public GameObject TwosCars;

    //cup
    public Button onecup;
    public GameObject OneCup;
    public Button TwoCups;
    public GameObject TwosCups;

    //chairss
    public Button onechair;
    public GameObject OneChair;
    public Button TwoChairs;
    public GameObject TwosChairs;

    //plane
    public Button OnePlane;
    public GameObject oneplane;

    //eraser
    public Button OneEraser;
    public GameObject oneeraser;

    //ship
    public Button OneShip;
    public GameObject oneship;

    //notes
    public Button OneNotes;
    public GameObject onenotes;

    //trashcan
    public Button Onecan;
    public GameObject onecan;

    //notebook
    public Button OneNB;
    public GameObject onenb;

	public Button next;
	public Button nexts;
	public Button nextss;
	public Button nextsss;

	public GameObject arrow;
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;

	public GameObject arrow4;
	public GameObject arrow5;
	public GameObject arrow6;
	public GameObject arrow7;
	
	public GameObject arrow8;
	public GameObject arrow9;
	public GameObject arrow10;	
	public GameObject arrow11;
	

	public GameObject def;
	public GameObject def1;
	public GameObject def2;
	public GameObject def3;	

	public GameObject def4;
	public GameObject def5;
	public GameObject def6;
	public GameObject def7;



    public void StartPanel()
    {
        StartingPanel.SetActive(false);
        ExampleOne.SetActive(true);
    }
    public void ExampleOnes()
    {
        ExampleOne.SetActive(false);
        ExampleTwo.SetActive(true);
    }
    public void ExampleTwos()
    {
        ExampleTwo.SetActive(false);
        ExampleThree.SetActive(true);
    }
    public void ExampleThrees()
    {
        ExampleThree.SetActive(false);
        Player.SetActive(true);
        Platform.SetActive(true);
    }
    public void ExampleFours()
    {
        ExampleFour.SetActive(false);
        ExampleFive.SetActive(true);
    }
    public void ExampleFives()
    {

        ExampleFive.SetActive(false);
        
    }
    public void clickT()
    {
        if (Ti.isPlaying)
        {
            Ti.Stop();
        }
        else
        {
            Ti.Play();
        }
        T.interactable = false;
        H.interactable = true;
        R.interactable = false;
        E.interactable = false;
		arrow.SetActive (false);
		arrow1.SetActive (true);
     //   EE.interactable = false;
    }
    public void ClickOne()
    {
        if (One.isPlaying)
        {
            One.Stop();
        }
        else
        {
            One.Play();
        }
		next.interactable = true;
    }
    public void ClickH()
    {
        if (eytch.isPlaying)
        {
            eytch.Stop();
        }
        else
        {
            eytch.Play();
        }
        T.interactable = false;
        H.interactable = false;
        R.interactable = true;
        E.interactable = false;
		arrow1.SetActive (false);
		arrow2.SetActive (true);
      //  EE.interactable = false;
    }
    public void ClickR()
    {
        if (ar.isPlaying)
        {
            ar.Stop();
        }
        else
        {
            ar.Play();
        }
        T.interactable = false;
        H.interactable = false;
        R.interactable = false;
        E.interactable = true;
		arrow2.SetActive (false);
		arrow3.SetActive (true);
      //  EE.interactable = false;

    }
    public void ClickE()
    {
        if (i.isPlaying)
        {
            i.Stop();
        }
        else
        {
            i.Play();
        }
        T.interactable = true;
        H.interactable = false;
        R.interactable = false;
        E.interactable = false;
		nexts.interactable = true;
		arrow3.SetActive (false);
		arrow.SetActive (true);
      //  EE.interactable = false;
    }
   
    public void ClickExampleOneSound()
    {
        Onecan.interactable = false;
        twosBirds.SetActive(false);
        onebird.interactable = false;
        twoBirds.interactable = true;
        OneBird.SetActive(true);
        oneplane.SetActive(false);
        onecan.SetActive(false);
		arrow4.SetActive (false);
		arrow5.SetActive (true);
		def.SetActive (true);
		def1.SetActive (false);
		def2.SetActive (false);
		def3.SetActive (false);
        if (SoundOne.isPlaying)
        {
            SoundOne.Stop();
        }
        else
        {
            SoundOne.Play();
        }
    }
    public void ClickExampleOnesSound()
    {
        Onecan.interactable = false;
        onebird.interactable = false;
        twoBirds.interactable = false;
        OnePlane.interactable = true;
        twosBirds.SetActive(true);
        OneBird.SetActive(false);
        oneplane.SetActive(false);
        onecan.SetActive(false);
		arrow5.SetActive (false);
		arrow6.SetActive (true);
		def.SetActive (false);
		def1.SetActive (true);
		def2.SetActive (false);
		def3.SetActive (false);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
    }
    public void ClickExampleOnessSound()
    {
        Onecan.interactable = true;
        onebird.interactable = false;
        twoBirds.interactable = false;
        OnePlane.interactable = false;
        twosBirds.SetActive(false);
        OneBird.SetActive(false);
        oneplane.SetActive(true);
        onecan.SetActive(false);
		arrow6.SetActive (false);
		arrow7.SetActive (true);
		def.SetActive (false);
		def1.SetActive (false);
		def2.SetActive (true);
		def3.SetActive (false);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
    }
    public void ClickExampleOnesssSound()
    {

        onebird.interactable = true;
        twoBirds.interactable = false;
        OnePlane.interactable = false;
        Onecan.interactable = false;
        twosBirds.SetActive(false);
        OneBird.SetActive(false);
        oneplane.SetActive(false);
        onecan.SetActive(true);
		arrow7.SetActive (false);
		arrow4.SetActive (true);
		def.SetActive (false);
		def1.SetActive (false);
		def2.SetActive (false);
		def3.SetActive (true);
        if (SoundFour.isPlaying)
        {
            SoundFour.Stop();
        }
        else
        {
            SoundFour.Play();
        }
		nextss.interactable = true;
    }
    public void ClickExampleTwoSound()
    {

        OnesNumber.SetActive(true);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
    }
    public void ClickExampleThreeSound()
    {
        OneShip.interactable = false;
        OneNB.interactable = false;
        OneEraser.interactable = false;
        OnessNumber.SetActive(false);
        onecar.interactable = false;
        TwoCars.interactable = true;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(true);
        oneeraser.SetActive(false);
        onenb.SetActive(false);
		arrow8.SetActive (false);
		arrow9.SetActive (true);
		def4.SetActive (true);
		def5.SetActive (false);
		def6.SetActive (false);
		def7.SetActive (false);
        if (SoundOne.isPlaying)
        {
            SoundOne.Stop();
        }
        else
        {
            SoundOne.Play();
        }
    }
    public void ClickExampleThreeSounds()
    {
        OneNB.interactable = false;
        TwoCars.interactable = false;
        onecar.interactable = false;
        OneEraser.interactable = true;
        TwosCars.SetActive(true);
        OnessNumber.SetActive(false);
        oneeraser.SetActive(false);
        onenb.SetActive(false);
		arrow9.SetActive (false);
		arrow10.SetActive (true);
		def4.SetActive (false);
		def5.SetActive (true);
		def6.SetActive (false);
		def7.SetActive (false);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
    }
    public void ClickExampleThreesSounds()
    {
        OneNB.interactable = true;
        TwoCars.interactable = false;
        onecar.interactable = false;
        OneEraser.interactable = false;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(false);
        oneeraser.SetActive(true);
        onenb.SetActive(false);
		arrow10.SetActive (false);
		arrow11.SetActive (true);
		def4.SetActive (false);
		def5.SetActive (false);
		def6.SetActive (true);
		def7.SetActive (false);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
    }
    public void ClickExampleThreesSoundss()
    {
        OneNB.interactable = false;
        TwoCars.interactable = false;
        onecar.interactable = true;
        OneEraser.interactable = false;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(false);
        oneeraser.SetActive(false);
        onenb.SetActive(true);
		arrow11.SetActive (false);
		arrow8.SetActive (true);
		def4.SetActive (false);
		def5.SetActive (false);
		def6.SetActive (false);
		def7.SetActive (true);
        if (SoundFour.isPlaying)
        {
            SoundFour.Stop();
        }
        else
        {
            SoundFour.Play();
        }
		nextsss.interactable = true;
    }
    public void ClickExampleFourSound()
    {
        OneShip.interactable = false;
        onecup.interactable = false;
        TwoCups.interactable = true;
        OnesssNumber.SetActive(true);
        TwosCups.SetActive(false);
        oneship.SetActive(false);
        if (SoundFour.isPlaying)
        {
            SoundFour.Stop();
        }
        else
        {
            SoundFour.Play();
        }
    }
    public void ClickExampleFourSounds()
    {
        onecup.interactable = false;
        TwoCups.interactable = false;
        OneShip.interactable = true;
        TwosCups.SetActive(true);
        OnesssNumber.SetActive(false);
        oneship.SetActive(false);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
    }
    public void ClickExampleFourSoundss()
    {
        onecup.interactable = true;
        TwoCups.interactable = false;
        OneShip.interactable = false;
        TwosCups.SetActive(false);
        OnesssNumber.SetActive(false);
        oneship.SetActive(true);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
    }
    public void ClickExampleFiveSound()
    {
        OneNotes.interactable = true;
        onechair.interactable = false;
        TwoChairs.interactable = true;
        OneNumber.SetActive(true);
        TwosChairs.SetActive(false);
        onenotes.SetActive(false);
        if (SoundOne.isPlaying)
        {
            SoundOne.Stop();
        }
        else
        {
            SoundOne.Play();
        }
    }
    public void ClickExampleFiveSounds()
    {
        onechair.interactable = false;
        TwoChairs.interactable = false;
        OneNotes.interactable = true;
        TwosChairs.SetActive(true);
        OneNumber.SetActive(false);
        onenotes.SetActive(false);

        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
    }
    public void ClickExampleFiveSoundss()
    {
        onechair.interactable = true;
        TwoChairs.interactable = false;
        OneNotes.interactable = false;
        TwosChairs.SetActive(false);
        OneNumber.SetActive(false);
        onenotes.SetActive(true);

        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
    }

    void Start()
    {
        Time.timeScale = 1f;

    }
    public void OpenFinishPanel()
    {
        ExampleFive.SetActive(false);
        Platform.SetActive(true);
        Player.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Number-Scene")
        {
            FinishPanel.SetActive(true);

        }
    }
}