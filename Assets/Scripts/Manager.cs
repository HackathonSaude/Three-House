using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : GameManager
{
	public float countToStartRound = 3;
	public float roundTime = 10;
	public float countToDecrease = 3;

	public bool valueAdd = false;
	public static bool startRound = false;

	public bool canShuffleClose;
	public bool startCount = true;

	public static bool canReset = false;

	public GameObject popUp;

	void Start () 
	{
		LoadGame ();
		canReset = true;
	}
	
	void Update ()
	{
		
		if (open) //se a publicacao for em acesso aberto
		{
			if (!valueAdd)
			{
				fame += 4;
				happiness += 4;
				reception += 5;

				valueAdd = true;
			}
		}
		if (close) //se a publicacao for em acesso fechado
		{
			if (!valueAdd)
			{
				fame += 5;
				happiness += 5;
				reception -= 4;

				valueAdd = true;
			}
		}

		if (valueAdd && startCount)
		{
			countToStartRound -= Time.deltaTime;
		}

		if (countToStartRound <= 0)
		{
			startRound = true;
			roundTime -= Time.deltaTime;
			startCount = false;
			countToDecrease -= Time.deltaTime;
		}

		if (countToDecrease <= 0)
		{
			fame --;
			happiness --;

			countToDecrease = 3;
		}

		if (startRound) 
		{
			if (fame >= 10) 
			{
				fame = 10;
			}

			if (happiness >= 10)
			{
				happiness = 10;
			}

			if (reception >= 10) 
			{
				reception = 10;
			}
			if (reception <= -10)
			{//se a recepcao for totalmente negativa o jogador perde
				reception = -10;
				gameEnded = true;
				startRound = false;
				Reset ();
				SceneManager.LoadScene ("Lose");
			}

			if (fame <= 0 || happiness <= 0) //caso o jogador fique sem alegria ou fama, ele tambem perde
			{
				gameEnded = true;
				startRound = false;
				Reset ();
				SceneManager.LoadScene ("Lose");
			}

			if (roundTime<= 0 && round >= 6)
			{
				gameEnded = true;
				startRound = false;
				Reset ();
				SceneManager.LoadScene ("End");
			}

			if (roundTime <= 0 && round <= 5)
			{
				round++;
				SaveGame ();
				SceneManager.LoadScene ("Instructions");
			}
		}
	}
}