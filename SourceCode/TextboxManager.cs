using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextboxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int EndALine;


	


	
	void Start () {

		if (textFile != null)
		{
			textLines = (textFile.text.Split('\n'));
		}
		if (EndALine == 0) {
			EndALine = textLines.Length -1;
		}
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
			Application.LoadLevel("StoryScene1");
			
		}
	}

}
