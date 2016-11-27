using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeSceneBtn : MonoBehaviour
{
	public Sprite sprite1;
	public Sprite sprite2;

	public string sceneName;

	void OnMouseEnter()
	{
		GetComponent<SpriteRenderer> ().sprite = sprite2;
	}
	void OnMouseExit()
	{
		GetComponent<SpriteRenderer> ().sprite = sprite1;
	}
	void OnMouseDown()
	{
		SceneManager.LoadScene (sceneName);
	}
}