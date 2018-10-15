using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HEART : MonoBehaviour {

	// Use this for initialization
	public Sprite[] HeartSprites;

	public Image HeartUI;

	private Player PLAYER;

	void Start() {
		PLAYER = GameObject.FindObjectOfType<Player> ();
		///PLAYER = GameObject.FindGameObjectsWithTag ("Player").GetType<Player> ();
	}

	void Update() {
		HeartUI.sprite = HeartSprites[PLAYER.CurHealth];
	}
}
