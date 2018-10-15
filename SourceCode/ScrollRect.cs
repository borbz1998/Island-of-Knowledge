using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollRect : MonoBehaviour {

	public RectTransform panel;
	public Button[] btn;
	public RectTransform center;

	private float[] distance;
	private bool dragging = false;
	private int minButtonNum;
	private int btnDistance;



	void Start () 
	{
		int btnLenght = btn.Length;
		distance = new float[btnLenght];

		btnDistance = (int)Mathf.Abs(btn[1].GetComponent<RectTransform>().anchoredPosition.x - btn[0].GetComponent<RectTransform>().anchoredPosition.x);
		print (btnDistance);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i<btn.Length; i++) {

			distance[i]= Mathf.Abs(center.transform.position.x - btn[i].transform.position.x);
		}
		float minDistance = Mathf.Min (distance);
		for (int a = 0; a<btn.Length;a++){
			if(minDistance == distance[a])
			{
				minButtonNum = a;
			}
		}
		if (!dragging) {
			LerpToButton(minButtonNum * -btnDistance);
		}

	}
	void LerpToButton(int position)
	{
		float newX = Mathf.Lerp(panel.anchoredPosition.x,position, Time.deltaTime * 10f);
		Vector2 newPosition = new Vector2 (newX, panel.anchoredPosition.y);
		panel.anchoredPosition = newPosition;
	}
	public void StartDrag()
	{
		dragging = true;
	}
	public void Endrag()
	{
		dragging = false;
	}

}
