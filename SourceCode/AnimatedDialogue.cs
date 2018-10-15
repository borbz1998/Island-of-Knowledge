using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimatedDialogue : MonoBehaviour {

	public Text TextArea;
	public string [] Strings;
	public float speed = 0.1f;
	public int WaitingTime = 5;

	int stringIndex = 0;
	int CharacterIndex = 0;
	void Start () {
		StartCoroutine (DisplayTimer ());
	}
	
	IEnumerator DisplayTimer()
	{
		while (1 == 1) {
			yield return new WaitForSeconds (speed);
			if(CharacterIndex > Strings[stringIndex].Length)
				{
				continue;
				}
			TextArea.text = Strings[stringIndex].Substring (0,CharacterIndex);
			CharacterIndex++;
			if(CharacterIndex == Strings[stringIndex].Length)
			{
				yield return new WaitForSeconds(WaitingTime);
				Application.LoadLevel("MainMenu");
			}
		}

	}

}
