using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCOREPREF : MonoBehaviour {

	public static int playerscore;
	public static int itemscore;

	public Text TEXT;
	public Text TIMETXT;
	public Text ITEMTXT;
	public int x ;

	void Start () 
	{

	
			PlayerPrefs.GetInt ("scorePref");
			PlayerPrefs.GetInt ("itemscorePref");

			playerscore = PlayerPrefs.GetInt ("scorePref");
			itemscore = PlayerPrefs.GetInt ("itemscorePref");

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	
			playerscore = int.Parse (TIMETXT.text);
			itemscore = int.Parse (ITEMTXT.text);

			PlayerPrefs.SetInt ("scorePref",playerscore);
			PlayerPrefs.SetInt ("itemscorePref",itemscore);
		    x = playerscore * itemscore;

			TEXT.text = x.ToString ();
		
	}

	public void SCORE()
	{
		if (playerscore > 0 && itemscore == 10) 
		{
			Player.Instance.star1.SetActive(true);
		}
		if (playerscore >= 30 && itemscore == 10) 
		{
			Player.Instance.star2.SetActive(true);
		}
		if (playerscore >= 60 && itemscore == 10) 
		{
			Player.Instance.star3.SetActive(true);
		}
		
	}
}
