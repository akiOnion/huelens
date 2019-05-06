using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_Checking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, 100.0f)) {
				ChangeScene (hit.transform.gameObject);
			}
		}
	}

	void ChangeScene(GameObject obj) {
		if (obj.name == "FrontDoor") {
			SceneManager.LoadScene ("Hallway_1");
		} else if (obj.name == "Horror_Door") {
			SceneManager.LoadScene ("Horror_Classroom");
		} else if (obj.name == "Chair_Portol") {
			SceneManager.LoadScene ("Dark_Hallway");
		} else if (obj.name == "Door_EndRoom") {
			SceneManager.LoadScene ("End_Room");
		} else if (obj.name == "kid") {
			SceneManager.LoadScene ("Ending");
		}

		if (obj.name == "Quit_Button") {
			Application.Quit ();
		}
	}

}
