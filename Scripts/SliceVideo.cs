using UnityEngine;
using System.Collections;

public class SliceVideo : MonoBehaviour {

	int i = 0;

	void Update() {
		    //Debug.Log ("test");
		    //Application.CaptureScreenshot("Assets/Traitement_video/Screenshot"+i+".png");
			i++;

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Application.OpenURL("file:///" + Application.dataPath + "/Resources/fileName.pdf");
		}
	}
}
