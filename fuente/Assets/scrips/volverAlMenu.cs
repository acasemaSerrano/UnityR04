﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverAlMenu : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("menu");
	}
}
