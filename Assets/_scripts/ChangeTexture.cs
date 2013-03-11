using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour {
public Texture2D t_static_tx = null;
public Texture2D t_dynamic_tx = null;
public WWW t_load = null;
 	void OnEnable() {
		//DoChangeTexture();	
		
	}

	
	void DoChangeTexture(string targetFile) {
		
		t_load = new WWW(targetFile);
		//yield return t_load;
		t_dynamic_tx = new Texture2D(200, 200);
		t_load.LoadImageIntoTexture(t_dynamic_tx);
		renderer.material.mainTexture = t_dynamic_tx;

	}
	
}
