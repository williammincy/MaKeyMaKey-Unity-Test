using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyPressDetection : MonoBehaviour {
	// list to hold all of the objects we are manipulating
	private List<GameObject> fills;

	// Use this for initialization
	void Start () {
		// collect all the objects
		fills = new List<GameObject>();
		fills.Add(GameObject.Find("GO_Up_Fill"));
		fills.Add(GameObject.Find("GO_Down_Fill"));
		fills.Add(GameObject.Find("GO_Left_Fill"));
		fills.Add(GameObject.Find("GO_Right_Fill"));
		fills.Add(GameObject.Find("GO_W_Fill"));
		fills.Add(GameObject.Find("GO_A_Fill"));
		fills.Add(GameObject.Find("GO_S_Fill"));
		fills.Add(GameObject.Find("GO_D_Fill"));
		HideFills();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateFills();
	}

	/**
	 * Iterates through the <code>fills</code> list to hide all of the objects within the collection
	 * @return void
	 */
	void HideFills() {
		foreach(GameObject go in fills) {
			go.SetActive(false);
		}
	}
	/**
	 * Evaluates each key that we are listening for against its corresponding <code>GameObject</code> to determine if we should 
	 * see the object. When the associating key is pressed the object is visible, otherwise the object is not visible
	 * @return void
	 */
	void UpdateFills() {
		fills[0].SetActive(Input.GetKey(KeyCode.UpArrow));
		fills[1].SetActive(Input.GetKey(KeyCode.DownArrow));
		fills[2].SetActive(Input.GetKey(KeyCode.LeftArrow));
		fills[3].SetActive(Input.GetKey(KeyCode.RightArrow));
		fills[4].SetActive(Input.GetKey(KeyCode.W));
		fills[5].SetActive(Input.GetKey(KeyCode.A));
		fills[6].SetActive(Input.GetKey(KeyCode.S));
		fills[7].SetActive(Input.GetKey(KeyCode.D));
	}
}
