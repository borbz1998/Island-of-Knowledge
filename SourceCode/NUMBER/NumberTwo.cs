using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberTwo : MonoBehaviour
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
    public void clickO()
    {
        if (Ow.isPlaying)
        {
            Ow.Stop();
        }
        else
        {
            Ow.Play();
        }
        O.interactable = false;
        N.interactable = true;
        E.interactable = false;
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
    public void ClickN()
    {
        if (En.isPlaying)
        {
            Ow.Stop();
        }
        else
        {
            En.Play();
        }
        O.interactable = false;
        N.interactable = false;
        E.interactable = true;
		arrow1.SetActive (false);
		arrow2.SetActive (true);
    }
    public void ClickE()
    {
        if (I.isPlaying)
        {
            Ow.Stop();
        }
        else
        {
            I.Play();
        }
        O.interactable = true;
        E.interactable = false;
        N.interactable = false;
		nexts.interactable = true;
		arrow2.SetActive (false);
		arrow.SetActive (true);
    }
    public void ClickExampleOneSound()
    {
        twosBirds.SetActive(false);
        onebird.interactable = false;
        twoBirds.interactable = true;
        OneBird.SetActive(true);
		arrow3.SetActive (false);
		arrow4.SetActive (true);
		def.SetActive (true);
		def1.SetActive (false);
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
       
        onebird.interactable = true;
        twoBirds.interactable = false;
        twosBirds.SetActive(true);
        OneBird.SetActive(false);
		arrow3.SetActive (true);
		arrow4.SetActive (false);
		def.SetActive (false);
		def1.SetActive (true);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
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
        OnessNumber.SetActive(false);
        onecar.interactable = false;
        TwoCars.interactable = true;
        TwosCars.SetActive(false);
        OnessNumber.SetActive(true);
		arrow5.SetActive (false);
		arrow6.SetActive (true);
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
    public void ClickExampleThreeSounds()
    {
        TwoCars.interactable = false;
        onecar.interactable = true;
        TwosCars.SetActive(true);
        OnessNumber.SetActive(false);
		arrow5.SetActive (true);
		arrow6.SetActive (false);
		def2.SetActive (false);
		def3.SetActive (true);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
		nextsss.interactable = true;
    }
    public void ClickExampleFourSound()
    {
        onecup.interactable = false;
        TwoCups.interactable = true;
        OnesssNumber.SetActive(true);
        TwosCups.SetActive(false);
		arrow7.SetActive (false);
		arrow8.SetActive (true);
		def5.SetActive (false);
		def4.SetActive (true);
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
        onecup.interactable = true;
        TwoCups.interactable = false;
        TwosCups.SetActive(true);
        OnesssNumber.SetActive(false);
		arrow7.SetActive (true);
		arrow8.SetActive (false);
		def4.SetActive (false);
		def5.SetActive (true);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
        }
		nextssss.interactable = true;
    }
    public void ClickExampleFiveSound()
    {
        onechair.interactable = false;
        TwoChairs.interactable = true;
        OneNumber.SetActive(true);
        TwosChairs.SetActive(false);
		arrow9.SetActive (false);
		arrow10.SetActive (true);
		def7.SetActive (false);
		def6.SetActive (true);
        if (SoundFive.isPlaying)
        {
            SoundFive.Stop();
        }
        else
        {
            SoundFive.Play();
        }
    }
    public void ClickExampleFiveSounds()
    {
        onechair.interactable = true;
        TwoChairs.interactable = false;
        TwosChairs.SetActive(true);
        OneNumber.SetActive(false);
		arrow9.SetActive (true);
		arrow10.SetActive (false);
		def6.SetActive (false);
		def7.SetActive (true);
        if (SoundTwo.isPlaying)
        {
            SoundTwo.Stop();
        }
        else
        {
            SoundTwo.Play();
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