using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[SerializeField]
	private Text ItemTxt; 

	public int collecteditems;

	public static GameManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<GameManager>();
			}
			return instance;
		}
	}
	public int CollectedItems
	{
		get 
		{
			return collecteditems; 
		}
		set
		{
			ItemTxt.text = value.ToString();
			this.collecteditems = value;
		
		} 
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
}
}
