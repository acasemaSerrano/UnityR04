using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {
	public void irAEscena(string nombre){
		SceneManager.LoadScene(nombre);
	}
}
