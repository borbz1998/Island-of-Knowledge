using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PauseRestartMenu : MonoBehaviour {

	//public timer _scoreA;

	public GameObject PausePanel;
	public GameObject TimeUPPanel;
	public GameObject OpeningPanel;
	public Text TIMETXT;

	private static int playerscore;
	public int score = playerscore ;
	public Text ITEMTXT;
	private static int itemscore;

	public GameObject textVG;
	public GameObject textG;
	public GameObject textF;


	void Start(){
		Time.timeScale = 0f;
	
	}

	public void PauseGame()
	{
		Time.timeScale = 0f;
		PausePanel.SetActive (true);
	}
	public void OpeningGame()
	{
		Time.timeScale = 0f;
		OpeningPanel.SetActive (true);
	}
	public void RestartGame()
	{
		Time.timeScale = 1f;
		Application.LoadLevel (Application.loadedLevel);

	}
	public void ResumeGame()
	{
		Time.timeScale = 1f;
		PausePanel.SetActive (false);
		OpeningPanel.SetActive (false);
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().WrongPanel.SetActive (false);
	}
	public void SceneToLoader(string level){
	
		Application.LoadLevel (level);
		Time.timeScale = 1f;
	
	}
	void Update () 
	{
		

	
	}
	



	public  void Tag1()
	{	
		FindObjectOfType<Player> ().SoundFirst.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelOne.SetActive (false);

		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {

				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textVG.SetActive (false);
				textG.SetActive (false);
			}
			 if (playerscore >= 30 && itemscore == 10) {
			
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);

			}
			 if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
		
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textVG.SetActive (false);
				textG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag2()
		{	FindObjectOfType<Player> ().SoundSecond.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelTwo.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);

			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag3()

		{	FindObjectOfType<Player> ().SoundThird.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelThree.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);

			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag4()
		{	FindObjectOfType<Player> ().SoundFourth.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelFour.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag5()
	{	FindObjectOfType<Player> ().SoundFifth.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelFive.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag6()
	{	FindObjectOfType<Player> ().SoundSixth.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelSix.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag7()
	{	FindObjectOfType<Player> ().SoundSeven.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelSeven.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}

		//	score = 10;
		}
	}
	public void Tag8()
	{	FindObjectOfType<Player> ().SoundEight.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelEight.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
		

			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);
				
				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag9()
	{	FindObjectOfType<Player> ().SoundNine.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelNine.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}
	}
	public void Tag10()
	{	
		FindObjectOfType<Player> ().SoundTen.Stop ();
		Time.timeScale = 1f;
		FindObjectOfType<Player> ().PanelTen.SetActive (false);
		
		if (GameManager.Instance.CollectedItems == 10) 
		{
			playerscore = int.Parse(TIMETXT.text);
			itemscore = int.Parse(ITEMTXT.text);
			score = playerscore;
			if (playerscore > 0 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 30 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star1.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textG.SetActive (true);
				textF.SetActive (false);
				textVG.SetActive (false);
			}
			if (playerscore >= 60 && itemscore == 10) {
				Player.Instance.FinishPanel.SetActive(true);

				Player.Instance.star3.SetActive (true);
				Player.Instance.star2.SetActive (true);
				Player.Instance.star1.SetActive (true);
				Player.Instance.star1B.SetActive (false);
				Player.Instance.star2B.SetActive (false);
				Player.Instance.star3B.SetActive (false);
				Time.timeScale = 0f;
				textVG.SetActive (true);
				textF.SetActive (false);
				textG.SetActive (false);
			}
			if (playerscore >= 0 && itemscore != 10) 
			{
				Player.Instance.FinishPanel.SetActive(true);
				Player.Instance.star3.SetActive (false);
				Player.Instance.star2.SetActive (false);
				Player.Instance.star1.SetActive (false);
				Player.Instance.star1B.SetActive (true);
				Player.Instance.star2B.SetActive (true);
				Player.Instance.star3B.SetActive (true);
				Time.timeScale = 0f;
				textF.SetActive (true);
				textG.SetActive (false);
				textVG.SetActive (false);
			}
		//	score = 10;
		}


	}











}
