using UnityEngine;
using System.Collections;
	public enum Mode
    {
        lowerlower, upperupper
    }
public class Director : MonoBehaviour {
	
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;
	public GameObject target;	
	
	private string option1string;
	private string option2string;
	private string option3string;
	private string targetString;
	
	private string option1File;
	private string option2File;
	private string option3File;
	private string targetFile;



 
    public Mode mode;
	string[] names = new string[3] {"Matt", "Joanne", "Robert"};

	string[] lowerLetters = new string[] {"a.png","b.png","c.png","d.png","e.png","f.png","g.png","h.png","i.png","j.png","k.png","l.png","m.png","n.png","o.png","p.png","q.png","r.png","s.png","t.png","u.png","v.png","w.png","x.png","y.png","z.png"};
	string[] upperLetters = new string[] {"a.png","b.png","c.png","d.png","e.png","f.png","g.png","h.png","i.png","j.png","k.png","l.png","m.png","n.png","o.png","p.png","q.png","r.png","s.png","t.png","u.png","v.png","w.png","x.png","y.png","z.png"};

	public bool correctmatch = true;
	// Use this for initialization
	void Start () {
		SetupOptions();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMessageTouched(string objectName) {
		
		Debug.Log ("Touched:" + objectName);
	}
	

	void SetupOptions() {
		if (mode == Mode.lowerlower) {
			option1string = lowerLetters[Random.Range(0,lowerLetters.Length)];
			option2string = lowerLetters[Random.Range(0,lowerLetters.Length)];
			option3string = lowerLetters[Random.Range(0,lowerLetters.Length)];

			
			
			option1File = "file://" + Application.dataPath + "/Resources/lower_letters/";
		 	option2File = "file://" + Application.dataPath + "/Resources/lower_letters/";
		 	option3File = "file://" + Application.dataPath + "/Resources/lower_letters/";
			targetFile = "file://" + Application.dataPath + "/Resources/lower_letters/";

		}	
		int i = Random.Range(0,3);
		if (i == 0) targetString = option1string;
		if (i == 1) targetString = option2string;
		if (i == 2) targetString = option3string;
		
		option1.BroadcastMessage("DoChangeTexture", option1File + option1string);
		option2.BroadcastMessage("DoChangeTexture", option2File + option2string);
		option3.BroadcastMessage("DoChangeTexture", option3File + option3string);
		target.BroadcastMessage("DoChangeTexture", targetFile + targetString);

		
		
		
		
	}
	
}
