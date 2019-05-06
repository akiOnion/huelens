using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour {

	void OnMouseDown() {
		print ("clicked");
		SceneManager.LoadScene ("Classroom");
	}

}
