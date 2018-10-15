using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour {

	public GameObject textBox;
	public Text theText;
	
	public TextAsset textFile;
	public string[] textLines;
	
	public int currentLine;
	public int EndALine;

	public AudioSource[] Audios;

	public int CurrentAudio;
	public int EndAudio;

	private AudioSource una;

	void Start () {
		if (textFile != null)
		{
			textLines = (textFile.text.Split('\n'));
		}
		if (EndALine == 0) {
			EndALine = textLines.Length -1;
		}
		CurrentAudio = Audios.Length;
		una = GameObject.Find ("StoryFirst").GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {

		theText.text = textLines [currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {
			currentLine += 1;
		}
		if (currentLine > EndALine) {
			textBox.SetActive(false);
			Application.LoadLevel("StoryFirst");
			
		}

		if (currentLine == 0) {
				Audios[1].Play();
		}
		if (currentLine == 1) {
				Audios[2].Play();
		}
	
	}
	public void Tap(){
		currentLine += 1;
		CurrentAudio += 1;
		una.Stop ();


	}
	public void bitch1(){
		Audios [1].Stop ();
	}
	public void bitch2(){
		Audios [2].Stop ();
	}
}
