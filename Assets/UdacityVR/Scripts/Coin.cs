using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public GameObject coinPoofPrefab;

	void Update () {
		// Animate the coin rotating
		transform.Rotate(0.0f, 1.0f, 0.0f);
	}

	public void OnCoinClicked () {
		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");

		// Clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
		Object.Instantiate (coinPoofPrefab, this.transform.position, coinPoofPrefab.transform.rotation);

		// Remove this coin from the scene
		Object.Destroy (this.gameObject, 0.5f);
	}
}
