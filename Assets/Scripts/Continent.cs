using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Continent : MonoBehaviour
{
	public int openRandom;
	public int closeRandom;
	public int code;
	public int areaCode;

	public float balloonCount = 3;

	public bool canShuffle;
	public bool balloonCanCount;
	public bool canClick = false;

	public GameObject balloon;

	void Start () 
	{
		canShuffle = true;
		balloonCanCount = false;
		//canShuffleClose = false;
		balloon.SetActive (false);
		GetComponent<BoxCollider2D> ().enabled = false;
	}
	
	void Update () 
	{

		if (Manager.startRound)//se comecou o round
		{
			if (GameManager.open)//verifico se esta em acesso aberto ou nao
			{
				ShuffleOpen ();
			}
			if (GameManager.close)
			{
				ShuffleClose ();
			}
		}

		if (balloonCanCount)
		{
			balloonCount -= Time.deltaTime;
		}

		if (balloonCount <= 0)
		{
			balloon.SetActive (false);
			GetComponent<BoxCollider2D> ().enabled = false;
			balloonCanCount = false;
			closeRandom = 0;
			openRandom = 0;

			if (canClick) 
			{
				Manager.fame -= 1;
				Manager.reception -= 1;
				Manager.happiness -= 1;

				canClick = false;
			}
		}
	}

	void ShuffleOpen()
	{
		if (canShuffle)
		{
			openRandom = Random.Range (1, 3);
			canShuffle = false;
		}

		if (openRandom == 1)
		{
			balloon.SetActive (true);
			GetComponent<BoxCollider2D> ().enabled = true;
			canClick = true;
			balloonCanCount = true;
		}
		else if (openRandom == 2) 
		{
			balloon.SetActive (false);
		}

	}
	void ShuffleClose()
	{
		if (canShuffle) 
		{
			closeRandom = Random.Range (1, 4);
			canShuffle = false;
		}

		if (closeRandom == 1)
		{
			balloon.SetActive (true);
			GetComponent<BoxCollider2D> ().enabled = true;
			canClick = true;
			balloonCanCount = true;
		}
		else /*if(closeRandom == 2)*/
		{
			balloon.SetActive (false);
		}
	}

	void OnMouseDown()
	{
		GameManager.fame += 1;
		GameManager.happiness += 1;
		openRandom = 0;
		closeRandom = 0;
		balloon.SetActive (false);
		GetComponent<BoxCollider2D> ().enabled = false;
		canClick = false;
	}
}