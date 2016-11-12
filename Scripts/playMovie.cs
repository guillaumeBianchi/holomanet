using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playMovie : MonoBehaviour {

	void Start () {
		((MovieTexture)GetComponent<RawImage>().texture).Play();
		((MovieTexture)GetComponent<RawImage> ().texture).loop = true;
	}

	void Update () {
	
	}
}
