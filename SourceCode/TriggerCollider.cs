using UnityEngine;
using System.Collections;

public class TriggerCollider : MonoBehaviour {

	private BoxCollider2D playerCollider;

	[SerializeField]
	private BoxCollider2D platformCollider;
	[SerializeField]
	private BoxCollider2D platformTrigger;
	void Start () 
	{
		playerCollider = GameObject.Find ("PLAYER").GetComponent<BoxCollider2D> ();
		Physics2D.IgnoreCollision (platformCollider, platformTrigger, true);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "PLAYER") 
		{
			Physics2D.IgnoreCollision(platformCollider,playerCollider, true );
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.name == "PLAYER") 
		{
			Physics2D.IgnoreCollision(platformCollider,playerCollider, false );
		}
	}
	// Update is called once per frame

}
