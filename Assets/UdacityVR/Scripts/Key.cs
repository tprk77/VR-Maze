using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public GameObject keyPoofPrefab;

	public Door door;

	void Update () {
		// Animate the key rotating
		transform.Rotate(0.0f, 0.0f, 1.0f);
	}

	public void OnKeyClicked () {
		// Prints to the console when the method is called
		Debug.Log ("'Key.OnKeyClicked()' was called");

		door.Unlock ();

		// Clone of the 'KeyPoof' prefab at this key's position and with the 'KeyPoof' prefab's rotation
		Object.Instantiate (keyPoofPrefab, this.transform.position, keyPoofPrefab.transform.rotation);

		// Remove this key from the scene
		Object.Destroy (this.gameObject, 0.5f);
	}
}
