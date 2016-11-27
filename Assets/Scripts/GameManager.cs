using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public static int reception = 0;
	public static int happiness = 0;
	public static int fame = 0;
	public static int round = 1;

	public static bool open = false;//acesso aberto
	public static bool close = false;//acesso fechado
	public static bool gameEnded = false;

	void Start ()
	{
		PlayerPrefs.DeleteAll ();
	}
	
	void Update ()
	{
		
	}
	public static void SaveGame()
	{//Salvo o jogo

		PlayerPrefs.SetInt ("receptionS", reception);
		PlayerPrefs.SetInt("happinessS",happiness);
		PlayerPrefs.SetInt("fameS",fame);
		PlayerPrefs.SetInt("roundS",round);
	}

	public static void LoadGame()
	{//Carrego o jogo


		reception = PlayerPrefs.GetInt("receptionS");

		happiness = PlayerPrefs.GetInt("happinessS");

		fame = PlayerPrefs.GetInt("fameS");
	
		round = PlayerPrefs.GetInt("roundS");
	

		open = false;
		close = false;

		Debug.Log ("jogo carregado");
	}

	public static void Reset()
	{
		if (gameEnded)
		{
			PlayerPrefs.DeleteAll ();
			gameEnded = false;
		}
	}
}