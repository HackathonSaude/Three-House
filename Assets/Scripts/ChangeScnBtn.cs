﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeScnBtn : MonoBehaviour
{
	public string sceneName;

	void OnMouseDown()
	{
		SceneManager.LoadScene (sceneName);
	}
}