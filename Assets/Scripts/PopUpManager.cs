using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PopUpManager : MonoBehaviour
{
	public static int open = 0;

	public bool changed;

	public Sprite openA;
	public Sprite closeA;

	public GameObject statusMiniature;

	void Start ()
	{
		changed = false;
	}
	
	void Update ()
	{
		if (open == 1)
		{//troco a img de stat do artigo
			statusMiniature.GetComponent<SpriteRenderer> ().sprite = openA;
			this.gameObject.SetActive (false);
			GameManager.open = true;
			GameManager.close = false;
		} 
		else if (open == 2)
		{
			statusMiniature.GetComponent<SpriteRenderer> ().sprite = closeA;
			this.gameObject.SetActive (false);
			GameManager.open = false;
			GameManager.close = true;
		}

		if (Manager.canReset) 
		{
			open = 0;
		}
	}
}