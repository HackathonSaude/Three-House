using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LikeBar : MonoBehaviour 
{
	public Sprite s0;
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;
	public Sprite s9;
	public Sprite s10;
	public Sprite s11;
	public Sprite s12;
	public Sprite s13;
	public Sprite s14;
	public Sprite s15;
	public Sprite s16;
	public Sprite s17;
	public Sprite s18;
	public Sprite s19;
	public Sprite s20;

	void Start ()
	{

	}

	void Update ()
	{
		switch (Manager.reception) 
		{
		case 0:
			GetComponent<SpriteRenderer> ().sprite = s0;
			break;
		case 1:
			GetComponent<SpriteRenderer> ().sprite = s1;
			break;
		case 2:
			GetComponent<SpriteRenderer> ().sprite = s2;
			break;
		case 3:
			GetComponent<SpriteRenderer> ().sprite = s3;
			break;
		case 4:
			GetComponent<SpriteRenderer> ().sprite = s4;
			break;
		case 5:
			GetComponent<SpriteRenderer> ().sprite = s5;
			break;
		case 6:
			GetComponent<SpriteRenderer> ().sprite = s6;
			break;
		case 7:
			GetComponent<SpriteRenderer> ().sprite = s7;
			break;
		case 8:
			GetComponent<SpriteRenderer> ().sprite = s8;
			break;
		case 9:
			GetComponent<SpriteRenderer> ().sprite = s9;
			break;
		case 10:
			GetComponent<SpriteRenderer> ().sprite = s10;
			break;
		case -1:
			GetComponent<SpriteRenderer> ().sprite = s11;
			break;
		case -2:
			GetComponent<SpriteRenderer> ().sprite = s12;
			break;
		case -3:
			GetComponent<SpriteRenderer> ().sprite = s13;
			break;
		case -4:
			GetComponent<SpriteRenderer> ().sprite = s14;
			break;
		case -5:
			GetComponent<SpriteRenderer> ().sprite = s15;
			break;
		case -6:
			GetComponent<SpriteRenderer> ().sprite = s16;
			break;
		case -7:
			GetComponent<SpriteRenderer> ().sprite = s17;
			break;
		case -8:
			GetComponent<SpriteRenderer> ().sprite = s18;
			break;
		case -9:
			GetComponent<SpriteRenderer> ().sprite = s19;
			break;
		case -10:
			GetComponent<SpriteRenderer> ().sprite = s20;
			break;



		}
	}
}