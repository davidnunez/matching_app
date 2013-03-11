using UnityEngine;
using System.Collections;

public class BroadcastMessageOnTouch : MonoBehaviour {
	
	public GameObject target;
	
	void OnEnable() {
		FingerGestures.OnFingerDown += FingerGestures_OnFingerDown;
	}
	void OnDisable() {
		FingerGestures.OnFingerDown -= FingerGestures_OnFingerDown;
	}	
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FingerGestures_OnFingerDown( int fingerIndex, Vector2 fingerPos )
    {
		GameObject touched_body = PickGameObject( fingerPos );
	    if( touched_body )
    	{
        	if (touched_body == this.gameObject)
			{
				target.BroadcastMessage("OnMessageTouched", name);
				//audioSource.PlayOneShot(audioClip);
			}
	    }
	}
	// utility method to raycast into the scene from the input screen position, looking for a rigidbody
    GameObject PickGameObject( Vector2 screenPos )
    {
        Ray ray = Camera.main.ScreenPointToRay( screenPos );
        RaycastHit hit;
     
        if( !Physics.Raycast( ray, out hit ) )
            return null;
        return hit.collider.gameObject;
    }
}
