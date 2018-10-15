using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClickSound : MonoBehaviour {

	public AudioClip sound;
	private Button button {get { return GetComponent<Button>();}}
	private AudioSource source {get { return GetComponent<AudioSource>();}}

	void Start () {
		gameObject.AddComponent<AudioSource>();
		source.clip = sound;
		source.playOnAwake = false;

		button.onClick.AddListener(()=>PlaySound());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void PlaySound()
	{
		source.PlayOneShot(sound);
	}
}
