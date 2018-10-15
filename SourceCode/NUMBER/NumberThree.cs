using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberThree : MonoBehaviour
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

	public Button next;
	public Button nexts;
	public Button nextss;
	public Button nextsss;
	public Button nextssss;
	public Button nextsssss;


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
	public GameObject arrow12;
	public GameObject arrow13;

	public GameObject arrow14;
	public GameObject arrow15;
	public GameObject arrow16;

	public GameObject def;
	public GameObject def1;
	public GameObject def2;

	public GameObject def3;	
	public GameObject def4;
	public GameObject def5;
	
	public GameObject def6;
	public GameObject def7;
	public GameObject def8;

	public GameObject def9;
	public GameObject def10;
	public GameObject def11;




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
        ExampleFour.SetActive(true);
    }
    public void ExampleFours()
    {
        ExampleFour.SetActive(false);
        ExampleFive.SetActive(true);
    }
    public void ExampleFives()
    {

        ExampleFive.SetActive(false);
        Player.SetActive(true);
        Platform.SetActive(true);
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
        EE.interactable = false;
		arrow.SetActive (false);
		arrow1.SetActive (true);
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
        EE.interactable = false;
		arrow1.SetActive (false);
		arrow2.SetActive (true);
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
        EE.interactable = false;
		arrow2.SetActive (false);
		arrow3.SetActive (true);

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
        T.interactable = false;
        H.interactable = false;
        R.interactable = false;
        E.interactable = false;
        EE.interactable = true;
		arrow3.SetActive (false);
		arrow4.SetActive (true);
    }
    public void ClickEE()
    {
        if (ee.isPlaying)
        {
            ee.Stop();
        }
        else
        {
            ee.Play();
        }
        T.interactable = true;
        H.interactable = false;
        R.interactable = false;
        E.interactable = false;
        EE.interactable = false;
		nexts.interactable = true;
		arrow4.SetActive (false);
		arrow.SetActive (true);
    }
    public void ClickExampleOneSound()
    {
        twosBirds.SetActive(false);
        onebird.interactable = false;
        twoBirds.interactable = true;
        OneBird.SetActive(true);
        oneplane.SetActive(false);
		arrow5.SetActive (false);
		arrow6.SetActive (true);
		def.SetActive (true);
		def1.SetActive (false);
		def2.SetActive (false);
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

        onebird.interactable = false;
        twoBirds.interactable = false;
        OnePlane.interactable = true;
        twosBirds.SetActive(true);
        OneBird.SetActive(false);
        oneplane.SetActive(false);
		arrow6.SetActive (false);
		arrow7.SetActive (true);
		def.SetActive (false);
		def1.SetActive (true);
		def2.SetActive (false);
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

        onebird.interactable = true;
        twoBirds.interactable = false;
        OnePlane.interactable = false;
        twosBirds.SetActive(false);
        OneBird.SetActive(false);
        oneplane.SetActive(true);
		arrow7.SetActive (false);
		arrow5.SetActive (true);
		def.SetActive (false);
		def1.SetActive (false);
		def2.SetActive (true);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
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
        OneEraser.interactable = false;
        OnessNumber.SetActive(false);
        onecar.interactable = false;
        TwoCars.interactable = true;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(true);
        oneeraser.SetActive(false);
		arrow8.SetActive (false);
		arrow9.SetActive (true);
		def3.SetActive (true);
		def4.SetActive (false);
		def5.SetActive (false);
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
        TwoCars.interactable = false;
        onecar.interactable = false;
        OneEraser.interactable = true;
        TwosCars.SetActive(true);
        OnessNumber.SetActive(false);
        oneeraser.SetActive(false);
		arrow9.SetActive (false);
		arrow10.SetActive (true);
		def3.SetActive (false);
		def4.SetActive (true);
		def5.SetActive (false);
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
        TwoCars.interactable = false;
        onecar.interactable = true;
        OneEraser.interactable = false;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(false);
        oneeraser.SetActive(true);
		arrow10.SetActive (false);
		arrow8.SetActive (true);
		def3.SetActive (false);
		def4.SetActive (false);
		def5.SetActive (true);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
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
		arrow11.SetActive (false);
		arrow12.SetActive (true);
		def6.SetActive (true);
		def7.SetActive (false);
		def8.SetActive (false);
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
		arrow12.SetActive (false);
		arrow13.SetActive (true);
		def6.SetActive (false);
		def7.SetActive (true);
		def8.SetActive (false);
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
		arrow13.SetActive (false);
		arrow11.SetActive (true);
		def6.SetActive (false);
		def7.SetActive (false);
		def8.SetActive (true);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
		nextssss.interactable = true;
    }
    public void ClickExampleFiveSound()
    {
        OneNotes.interactable = true;
        onechair.interactable = false;
        TwoChairs.interactable = true;
        OneNumber.SetActive(true);
        TwosChairs.SetActive(false);
        onenotes.SetActive(false);
		arrow14.SetActive (false);
		arrow15.SetActive (true);
		def9.SetActive (true);
		def10.SetActive (false);
		def11.SetActive (false);
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
		arrow15.SetActive (false);
		arrow16.SetActive (true);
		def9.SetActive (false);
		def10.SetActive (true);
		def11.SetActive (false);
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
		arrow16.SetActive (false);
		arrow14.SetActive (true);
		def9.SetActive (false);
		def10.SetActive (false);
		def11.SetActive (true);
        if (SoundThree.isPlaying)
        {
            SoundThree.Stop();
        }
        else
        {
            SoundThree.Play();
        }
		nextsssss.interactable = true;
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