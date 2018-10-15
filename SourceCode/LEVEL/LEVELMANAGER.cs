using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class LEVELMANAGER : MonoBehaviour {

	public int scores ;

	//private static int scores; 
	[System.Serializable]
	public class Level
	{
		public string LevelText;
		public Button button1;
		public int Unlocked;
		public bool IsInteractable;
	
		//public Button.ButtonClickedEvent OnClickEvent;
	}


   

	public GameObject levelButton;
	public Transform Spacer;
	public List<Level>LevelList;

	//private PauseRestartMenu pauseresmenu;

	// Use this for initialization
	void Start () {
		//DeleteAll ();
		FillList ();



	}

	void FillList()
	{
		//PlayerPrefs.GetInt ("scorePref");
		//scores = PlayerPrefs.GetInt ("scorePref");


		foreach (var level in LevelList) {
			GameObject newbutton = Instantiate (levelButton) as GameObject;
			LEVELBUTTON button = newbutton.GetComponent<LEVELBUTTON>();
			button.LevelText.text = level.LevelText;


			if (PlayerPrefs.GetInt(button.LevelText.text)== 1)
			{
				level.Unlocked = 1;
				level.IsInteractable = true;
			}

			button.unlocked = level.Unlocked;
			button.GetComponent<Button>().interactable = level.IsInteractable;
			button.GetComponent<Button>().onClick.AddListener(() => loadedlevel(button.LevelText.text)) ;

		
			if (PlayerPrefs.GetInt(button.LevelText.text + "_score") > 0 )
			{

				button.Star1.SetActive(true);
			}
		
			if (PlayerPrefs.GetInt(button.LevelText.text + "_score") >= 300 )
			{

				button.Star1.SetActive(true);
				button.Star2.SetActive(true);
			}
		
			if (PlayerPrefs.GetInt(button.LevelText.text + "_score") >= 600 )
			{
				button.Star1.SetActive(true);
				button.Star2.SetActive(true);
				button.Star3.SetActive(true);
			}
			//if (PlayerPrefs.GetInt("itemscorePref") <= 9)
		//{
				
			//	button.Star1.SetActive(false);
			//	button.Star2.SetActive(false);
			//	button.Star3.SetActive(false);
			//}
			
	
			newbutton.transform.SetParent(Spacer); 
		}
		SaveAll ();
		PlayerPrefs.SetInt ("scorePref", 0);
		PlayerPrefs.SetInt ("itemscorePref", 0);
	}
	void SaveAll()
	{
	//	if (PlayerPrefs.HasKey ("Level1")) {
	//		return;
	//	} 
	//	else {
			GameObject[] allbutton = GameObject.FindGameObjectsWithTag ("LevelButton");

			foreach (GameObject buttons in allbutton) {
				LEVELBUTTON button = buttons.GetComponent<LEVELBUTTON> ();
				PlayerPrefs.SetInt (button.LevelText.text, button.unlocked);
			}
		//}
	}

	void DeleteAll()
	{
		PlayerPrefs.DeleteAll ();
	}

	void loadedlevel(string value)
	{
		Application.LoadLevel (value);
	}
	public void SceneToLoad(string level){
		Application.LoadLevel (level);
		Time.timeScale = 1f;
	}
		
}
