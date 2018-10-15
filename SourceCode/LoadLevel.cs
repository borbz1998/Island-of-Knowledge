using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	
	public string PlayGameLevel;
	public GameObject ConfirmPanel;
	public GameObject CreditPanel;
	public GameObject SettingPanel;
	public GameObject OpeningPanel;
	public GameObject Circle;
	public GameObject Triangle;
	public GameObject Square;
	public GameObject Rectangle;
	public GameObject Diamond;
	public GameObject Heart;
	public GameObject Star;
	public GameObject Oval;
	public GameObject starpanel;
	public GameObject TTpanel;

	public GameObject FINALpanel;



	void Start(){
		Time.timeScale = 1f;
	}
	public void PlayGame()
	{
		Application.LoadLevel("WorldSelection");
	}
	
	public void ConfirmExit()
	{
		ConfirmPanel.SetActive (true);
	}
	public void No()
	{
		ConfirmPanel.SetActive (false);
	}
	public void Yes()
	{
		Application.Quit();
	}
	public void settings(){
		SettingPanel.SetActive (true);
	}
	public void SettingOff(){
		SettingPanel.SetActive (false);
	}
	public void SceneToLoad(string level){
		PlayerPrefs.SetInt ("scorePref", 0);
		PlayerPrefs.SetInt ("itemscorePref", 0);
		Application.LoadLevel (level);
		Time.timeScale = 1f;
	}
	public void PanelOn(){
		CreditPanel.SetActive (true);
	}
	public void PanelOff(){
		CreditPanel.SetActive (false);
	}
	public void TIPON(){
		OpeningPanel.SetActive (true);
		Circle.SetActive (false);
		Square.SetActive (false);
		Triangle.SetActive (false);
		Rectangle.SetActive (false);
		Heart.SetActive (false);
		Oval.SetActive (false);
		Diamond.SetActive (false);
		Star.SetActive (false);
		starpanel.SetActive (false);
		TTpanel.SetActive (false);
	
	}
	public void TIPOff(){
		OpeningPanel.SetActive (false);
		Circle.SetActive (true);
		Square.SetActive (true);
		Triangle.SetActive (true);
		Rectangle.SetActive (true);
		Heart.SetActive (true);
		Oval.SetActive (true);
		Diamond.SetActive (true);
		Star.SetActive (true);
		starpanel.SetActive (true);
		TTpanel.SetActive (true);
	
	}
	public void HELPON(){
		OpeningPanel.SetActive (true);
		starpanel.SetActive (false);
		TTpanel.SetActive (false);
		
	}
	public void HELPOff(){
		OpeningPanel.SetActive (false);
		starpanel.SetActive (true);
		TTpanel.SetActive (true);

	}
	public void colorON(){
		OpeningPanel.SetActive (true);
		Circle.SetActive (false);
		Square.SetActive (false);
		Triangle.SetActive (false);
		Rectangle.SetActive (false);
		Heart.SetActive (false);
		Oval.SetActive (false);
		Diamond.SetActive (false);
		Star.SetActive (false);
		starpanel.SetActive (false);
		TTpanel.SetActive (false);
		
	}
	public void colorOff(){
		OpeningPanel.SetActive (false);
		Circle.SetActive (true);
		Square.SetActive (true);
		Triangle.SetActive (true);
		Rectangle.SetActive (true);
		Heart.SetActive (true);
		Oval.SetActive (true);
		Diamond.SetActive (true);
		Star.SetActive (true);
		starpanel.SetActive (true);
		TTpanel.SetActive (true);
		
	}
	public void finalon(){
		FINALpanel.SetActive (true);
	}
}
