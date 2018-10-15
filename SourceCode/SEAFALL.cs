using UnityEngine;
using System.Collections;

public class SEAFALL : MonoBehaviour {

	public float KnockbackForce;
	private Player PLAYER;
	
	// Use this for initialization
	void Start () {
		PLAYER = GameObject.FindObjectOfType<Player>();
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "PLAYER") 
		{
			PLAYER.SeaDamage(5);
			
			StartCoroutine(PLAYER.Knockback(0.02f,50, PLAYER.transform.position));
			
			
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
