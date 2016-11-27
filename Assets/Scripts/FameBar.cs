using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FameBar : MonoBehaviour 
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

	void Start ()
	{
	
	}
	
	void Update ()
	{
		switch (Manager.fame) 
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



		}
	}
}