using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tigger : MonoBehaviour {
	
	public GameObject textBox;
	public Text theText;
	
	public TextAsset textFile;
	public string[] textLines;
	
	public int currentLine;
	public int EndALine;
	
	public AudioSource[] Audios;
	public int CurrentAudio;
	
	
	
	
	void Start () {
		
		if (textFile != null)
		{
			textLines = (textFile.text.Split('\n'));
		}
		if (EndALine == 0) {
			EndALine = textLines.Length -1;
		}
		CurrentAudio = Audios.Length;
	}
	void Update(){
		
		
		theText.text = textLines [currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {
			currentLine += 1;
		}
		if (currentLine > EndALine) {
			textBox.SetActive(false);
			Application.LoadLevel("MainMenu");
		}
		if (currentLine == 0) {
			Audios[1].Play();
		}
		if (currentLine == 1) {
			Audios[2].Play();
		}
		if (currentLine == 2) {
			Audios[3].Play();
		}

	}
	public void EnableTextBox(){
		textBox.SetActive(true);
		
	}
	public void DisableTextBox(){
		
		textBox.SetActive(false);
	}
	
	private void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Story") {
			textBox.SetActive(true);
			Audios[0].Play();
			
		}
	}
	public void Tap(){
		currentLine += 1;
		CurrentAudio += 1;
	}
	
}
