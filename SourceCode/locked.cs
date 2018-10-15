using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class locked : MonoBehaviour {

	public GameObject A;
	public GameObject B;
	public GameObject C;
	public GameObject D;
	public GameObject E;
	public GameObject F;
	public GameObject G;
	public GameObject H;
	public GameObject I;
	public GameObject J;
	//public GameObject K;
	//public GameObject L;
	//public GameObject M;
	//public GameObject N;
	//public GameObject O;
	//public GameObject P;
	//public GameObject Q;
	//public GameObject R;
	//public GameObject S;
	//public GameObject T;
	//public GameObject U;
	//public GameObject V;
	//public GameObject W;
	//public GameObject X;
	//public GameObject Y;
	//public GameObject Z;

	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	public Button button6;
	public Button button7;
	public Button button8;
	public Button button9;
	public Button button10;
	public Button button11;
	//public Button button12;



	public Text TEXT;
	public Text AA;
	public Text AB;
	public Text AC;
	public Text AD;
	public Text AE;
	public Text AF;
	public Text AG;
	public Text AH;
	public Text AI;
	public Text AJ;
	public Text AK;
	
	public int x;
	public int aa = 0;
	public int ab = 0;
	public int ac = 0;
	public int ad = 0;
	public int ae = 0;
	public int af = 0;
	public int ag = 0;
	public int ah = 0;
	public int ai = 0;
	public int aj = 0;
	public int ak = 0;


	public static int playerscore;
	public static int itemscore;




	void Start () {
	
		PlayerPrefs.GetInt ("scorePref");
		PlayerPrefs.GetInt ("itemscorePref");
		
		playerscore = PlayerPrefs.GetInt ("scorePref");
		itemscore = PlayerPrefs.GetInt ("itemscorePref");


	}
	
	// Update is called once per frame
	void Update () {
		TEXT.text = x.ToString();
		x = playerscore * itemscore;


		UnlockA ();
		UnlockB ();
	}
	public void UnlockA(){
		if (x >= 600 ) 
		{
			A.SetActive(false);
			aa = 1 ;
			button2.interactable = true;
			AA.text = aa.ToString ();
		}
	}

	public void UnlockB(){
		if (x >= 600 )
		{
			if(aa == 1)
			{
				ab = 1;
				B.SetActive (false);
				
				button3.interactable = true;
				AB.text = ab.ToString ();
			}
		} 
		if (x < 600 && aa == 1)
		{
			A.SetActive (false);
			button2.interactable = true;
		}
	}
	public void UnlockC(){
		if (x >= 600 && ac == 1) {
			C.SetActive (false);
			ac = 1;
			button4.interactable = true;
			AC.text = ac.ToString ();
		} 
		if (x < 600 && ab == 1)
		{
			B.SetActive (false);
			button3.interactable = true;
		}
	}
	public void UnlockD(){
		if (x >= 600 && ad == 1) {
			D.SetActive (false);
			ad = 1;
			button5.interactable = true;
			AD.text = ad.ToString ();
		} 
		if (x < 600 && ac == 1)
		{
			C.SetActive (false);
			button4.interactable = true;
		}
	}
	public void UnlockE(){
		if (x >= 600 && ae == 1) {
			E.SetActive (false);
			ae = 1;
			button6.interactable = true;
			AE.text = ae.ToString ();
		} 
		if (x < 600 && ad == 1)
		{
			D.SetActive (false);
			button5.interactable = true;
		}
	}
	public void UnlockF(){
		if (x >= 600 && af == 1) {
			F.SetActive (false);
			af = 1;
			button7.interactable = true;
			AF.text = af.ToString ();
		} 
		if (x < 600 && ae == 1)
		{
			E.SetActive (false);
			button6.interactable = true;
		}
	}
	public void UnlockG(){
		if (x >= 600 && ag == 1) {
			G.SetActive (false);
			ag = 1;
			button8.interactable = true;
			AG.text = ag.ToString ();
		} 
		if (x < 600 && af == 1)
		{
			F.SetActive (false);
			button7.interactable = true;
		}
	}
	public void UnlockH(){
		if (x >= 600 && ah == 1) {
			H.SetActive (false);
			ah = 1;
			button9.interactable = true;
			AH.text = ah.ToString ();
		} 
		if (x < 600 && ag == 1)
		{
			G.SetActive (false);
			button8.interactable = true;
		}
	}
	public void UnlockI(){
		if (x >= 600 && ai == 1) {
			I.SetActive (false);
			ai = 1;
			button10.interactable = true;
			AI.text = ai.ToString ();
		} 
		if (x < 600 && ah == 1)
		{
			H.SetActive (false);
			button9.interactable = true;
		}
	}

	public void UnlockJ(){
		if (x >= 600 && aj == 1) {
			J.SetActive (false);
			ai = 1;
			button11.interactable = true;
			AJ.text = aj.ToString ();
		} 
		if (x < 600 && ai == 1)
		{
			I.SetActive (false);
			button10.interactable = true;
		}
	}

	
}
