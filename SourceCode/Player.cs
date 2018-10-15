using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {

	private static Player instance;

	public GameObject PanelOne;
	public GameObject PanelTwo;
	public GameObject PanelThree;
	public GameObject PanelFour;
	public GameObject PanelFive;
	public GameObject PanelSix;
	public GameObject PanelSeven;
	public GameObject PanelEight;
	public GameObject PanelNine;
	public GameObject PanelTen;
	public GameObject WrongPanel;


	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public GameObject star1B;
	public GameObject star2B;
	public GameObject star3B;

	public GameObject OpeningPanel;
	public GameObject TimeUpPanel;
	public GameObject DeathPanel;
	public GameObject PausePanel;
	public GameObject FinishPanel;


	public AudioSource JumpSound;
	public AudioSource DeathSound;

	
	public  AudioSource SoundFirst;
	public AudioSource SoundSecond;
	public AudioSource SoundThird;
	public AudioSource SoundFourth;
	public AudioSource SoundFifth;
	public AudioSource SoundSixth;
	public AudioSource SoundSeven;
	public AudioSource SoundEight;
	public AudioSource SoundNine;
	public AudioSource SoundTen;
	
	public TIMEMANAGER timemanager;

	public AudioClip death;

	public static Player Instance 
	{
		get 
		{
			if (instance == null)
			{
				instance = GameObject.FindObjectOfType<Player>();
			}
			return instance;
		}
	}

	private float direction;

	private bool move;

	private float BtnHorizontal;

	private Animator myAnimator;
	[SerializeField]
	private float movementspeed;

	//private bool slide;

	private bool facingRight; 
	[SerializeField]
	private Transform[] GroundPoints ;
	
	[SerializeField]
	private float groundRadius;

	[SerializeField]
	private LayerMask whatIsGround;

	//private bool isGround;

	//private bool jump;
	[SerializeField]
	private bool airControl;
	[SerializeField]
	private float jumpforce;
	// Use this for initialization


	public int CurHealth;


	public int MaxHealth = 5	;


	public Rigidbody2D MyRigidBody{
		get;
		set;
	}
	public bool SLIDE {
		get;
		set;
	}
	public bool JUMP {

		get;
		set;
	}
	public bool ONGROUND {
		get;
		set;
	}

	public bool IsFalling {

		get
		{
			return MyRigidBody.velocity.y < 0;
		}
	}

	public void OpeningGame()
	{
		Time.timeScale = 0f;
		OpeningPanel.SetActive (true);
	}
	void Start () 
	{

		MyRigidBody = GetComponent<Rigidbody2D> ();
		myAnimator = GetComponent<Animator> ();
		facingRight = true;

		CurHealth = MaxHealth;
		OpeningGame ();
	}
	void Update()
	{
		HandleInput ();

	

		if (CurHealth > MaxHealth) 
		{
			CurHealth = MaxHealth;
		}
		if (CurHealth <= 0) 
		{

			Die();
		}
	

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float horizontal = Input.GetAxis("Horizontal");

		ONGROUND = IsGrounded ();
	
		if (move) 
		{
			this.BtnHorizontal = Mathf.Lerp(BtnHorizontal,direction,Time.deltaTime * 5);
			HandleMovement(BtnHorizontal);
			Flip(direction);
		} 
		else 
		{
			HandleMovement (horizontal);
			Flip (horizontal);
		}

	

		HandleLayer ();
	//	ResetValues ();
	}
	private void HandleMovement(float horizontal)
	{
		if (IsFalling) 
		{
			gameObject.layer = 10;
			myAnimator.SetBool("Land", true);
		}
		if (!SLIDE && (ONGROUND || airControl)) 
		{
			MyRigidBody.velocity = new Vector2(horizontal * movementspeed, MyRigidBody.velocity.y);
		}
		if (JUMP && MyRigidBody.velocity.y == 0) 
		{
			MyRigidBody.AddForce(new Vector2(0,jumpforce));
		}
		myAnimator.SetFloat("Speed" , Mathf.Abs(horizontal)); 
		//*if (myRigidbody.velocity.y < 0) 
		//{
		//	myAnimator.SetBool("Land", true);
		//}
		//if (isGround && jump) 
		//{
		//	isGround = false;
		//	myRigidbody.AddForce(new Vector2(0,jumpforce));
		//	myAnimator.SetTrigger("Jump");
		//}

		//if (!myAnimator.GetBool ("Slide") && (isGround || airControl)) 
		//{
		//	myRigidbody.velocity = new Vector2 (horizontal * movementspeed, myRigidbody.velocity.y);
		//}

		//if (slide && !this.myAnimator.GetCurrentAnimatorStateInfo (0).IsName ("SLIDE")) 
		//{
		//	myAnimator.SetBool ("Slide", true);
		//} 
		//else if (!this.myAnimator.GetCurrentAnimatorStateInfo (0).IsName ("SLIDE")) 
		//{
		//	myAnimator.SetBool("Slide",false);
		//}

		//myAnimator.SetFloat ("Speed", Mathf.Abs(horizontal)); 
	}

	private void HandleInput()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !IsFalling) 
		{
			JumpSound.Play();
			myAnimator.SetTrigger("Jump");
		}
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			myAnimator.SetTrigger("Slide");
		}
	}
	private void Flip(float horizontal)
	{
		if (horizontal > 0  && !facingRight || horizontal < 0 && facingRight) 
		{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
	//private void ResetValues()
	//{
	//	slide = false;
	//	jump = false;
	//}
	private bool IsGrounded()
	{
		if (MyRigidBody.velocity.y <= 0) 
		{
			foreach(Transform point in GroundPoints )
			{
				Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position,groundRadius,whatIsGround); 
				for (int i = 0; i < colliders.Length ; i++)
				{
					if (colliders[i].gameObject != gameObject)
					{
						//myAnimator.ResetTrigger("Jump");
						//myAnimator.SetBool("Land", false);
						return true;
					}
				}
			}
		}
		return false;
	}

	private void HandleLayer()
	{
		if (!ONGROUND) {
			myAnimator.SetLayerWeight (1, 1);
		} else {
			myAnimator.SetLayerWeight(1,0);
		}
	}


	void Die () 
	{
		//if (CurHealth != 0) {
			
		//	myAnimator.SetTrigger ("damage");
		//} 
		//else 
		//{e
		//	myAnimator.SetTrigger("die");
		//audio.PlayOneShot(death, 0.1f);

		DeathPanel.SetActive(true);
		PlayerPrefs.SetInt ("scorePref", 0);
		PlayerPrefs.SetInt ("itemscorePref", 0);

		//Application.LoadLevel (Application.loadedLevel);

	}
	
	public void Damage	(int dmg)
	{

		CurHealth -= dmg;
		gameObject.GetComponent<Animation>().Play("RED_DAMAGE");
		if (CurHealth == 0) {
			Time.timeScale = 0f;

		}
	}

	
	public void SeaDamage	(int dmgs)
	{
		
		CurHealth = 0;
		Time.timeScale = 0f;
		//gameObject.GetComponent<Animation>().Play("RED_DAMAGE");
		
	}

	public IEnumerator Knockback(float knockDur,float knockbackPwr, Vector3 knockbackDir)
	{

		knockbackDir.y = 1 ;
		float timer = 0;
		while (knockDur > timer) 
		{
			timer += Time.deltaTime;
			MyRigidBody.AddForce(new Vector3(knockbackDir.x * 0, knockbackDir.y * -100,
			                                 transform.position.z)); 
		}
		yield return 0;
	}
	//public override bool ISDIE 
	//{
	//	get 
	//	{
	//		return CurHealth <=0 ;
	//	}
	//}
	//public override IEnumerator TakeDamage()
	//{
	//	if (!ISDIE) {
	//		myAnimator.SetTrigger ("Damage");
	//	}
	//	else 
	//	{
	//		myAnimator.SetTrigger("Die");
	//		yield return 0;
	//	}
	//}


	private void OnCollisionEnter2D (Collision2D other)
	{
	
		if (other.gameObject.tag == "Tag 1") {

			SoundFirst.Play();
			Time.timeScale = 0f;
			PanelOne.SetActive(true);
			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);


			
		}
		if (other.gameObject.tag == "Tag 2") {
			SoundSecond.Play ();
			Time.timeScale = 0f;
			PanelTwo.SetActive(true);
			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 3") {
			SoundThird.Play();
			Time.timeScale = 0f;
			PanelThree.SetActive(true);
			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 4") {
			SoundFourth.Play();
			Time.timeScale = 0f;
			PanelFour.SetActive(true);
			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 5") {
			SoundFifth.Play();
			Time.timeScale = 0f;
			PanelFive.SetActive(true);

			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 6") {
			SoundSixth.Play();
			Time.timeScale = 0f;
			PanelSix.SetActive(true);

			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 7") {
			SoundSeven.Play();
			Time.timeScale = 0f;
			PanelSeven.SetActive(true);

			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 8") {
			SoundEight.Play();
			Time.timeScale = 0f;
			PanelEight.SetActive(true);

			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 9") {
			SoundNine.Play();
			Time.timeScale = 0f;
 			PanelNine.SetActive(true);

			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "Tag 10") {
			SoundTen.Play();
			Time.timeScale = 0f;
			PanelTen.SetActive(true);
			GameManager.Instance.CollectedItems++;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "timer") {
			timemanager.startingTime += 10;
			Destroy (other.gameObject);
		
		}
		if (other.gameObject.tag == "heart") {
			CurHealth += 1;
			Destroy (other.gameObject);
			
		}
		if (other.gameObject.tag == "MISTAKE") {
			CurHealth -= 1;
			Time.timeScale = 0f;
			WrongPanel.SetActive(true);
			Destroy (other.gameObject);
			
		}



	}
		public void BtnJump()
		{
		if (JumpSound.isPlaying) 
		{
			JumpSound.Stop ();
		} 
		else 
		{
			JumpSound.Play();
		}
		myAnimator.SetTrigger("Jump");
		}

		public void BtnSlide()
		{
		myAnimator.SetTrigger("Slide");
		}

		public void BtnMove(float direction)
		{
		this.direction = direction; 
		this.move = true;
		}
	
		public void BtnStopMove()
		{
		this.direction = 0;
		this.BtnHorizontal = 0;
		move = false;
		} 
	public void StopAppleSound()
	{

	}
	


	
}

