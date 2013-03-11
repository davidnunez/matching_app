using UnityEngine;
using System.Collections;
	public enum Mode
    {
        lowerlower, upperupper, categories
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
	string[] vehicles = new string[] {"Airplane.jpg","bicycle.jpg","car.jpg","firetruck.jpg","motorcycle.jpg","schoolbus.jpg","toyfiretruck.jpg","toytanktruck.jpg"};
	string[] food = new string[] {"apple.jpg","banana.jpg","bnana.png","bread.jpg","bread.png","candy.jpg","cheese.jpg","cookie.jpg","cracker02.jpg","drink.png","egg.jpg","icecream.png","juice.png","orange.jpg","pitabread.jpg","pizza.jpg","raisins.jpg","snowpeas02.jpg","toast.jpg"};
	string[] smallHouseholdItems = new string[] {"50dollarsbill.jpg","bowl02.jpg","box01.jpg","broom.jpg","brush05b.jpg","cardboardbox.jpg","carkeys.jpg","clock01a.jpg","clock05.jpg","comb.jpg","fork03c.jpg","glass02a.jpg","glasses01a.jpg","hammer-Plastic-Toy-Hammer.jpg","lamp04a.jpg","light.png","lightbulb01.jpg","papertowel.jpg","pillow01a.jpg","plant04b.jpg","plant08.jpg","radio02.jpg","scissors01.jpg","scissors06.jpg","soap.jpg","soap01.jpg","spoon02b.jpg","sunglasses02b.jpg","toothbrush.jpg","towel03b.jpg","watch01.jpg","watch05.jpg","winebottle02.jpg","wineglass02.jpg","woodenspoon.jpg"};
	string[] outside = new string[] {"flower.jpg", "plasticflower01a.jpg", "shovel01.jpg"};

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
			Debug.Log ("Loading LowerLower");
			option1File = "file://" + Application.dataPath + "/Resources/lower_letters/";
		 	option2File = "file://" + Application.dataPath + "/Resources/lower_letters/";
		 	option3File = "file://" + Application.dataPath + "/Resources/lower_letters/";

			
			option1string = lowerLetters[Random.Range(0,lowerLetters.Length)];
			option2string = lowerLetters[Random.Range(0,lowerLetters.Length)];
			option3string = lowerLetters[Random.Range(0,lowerLetters.Length)];

			
			
			

		}
		
		if (mode == Mode.categories) {
			Debug.Log ("Loading Categories");

			option1File = "file://" + Application.dataPath + "/Resources/food/";
		 	option2File = "file://" + Application.dataPath + "/Resources/vehicles/";
		 	option3File = "file://" + Application.dataPath + "/Resources/smallhouseholditems/";

			
			
			option1string = food[Random.Range(0,food.Length)];
			option2string = vehicles[Random.Range(0,vehicles.Length)];
			option3string = smallHouseholdItems[Random.Range(0,smallHouseholdItems.Length)];
			Debug.Log (option1File + option1string);
		}
		
		
					int i = Random.Range(0,3);
			if (i == 0) { 
				targetString = option1string;
				targetFile = option1File;
			}
			if (i == 1) { 
				targetString = option2string;
				targetFile = option2File;
			}
			if (i == 2) { 
				targetString = option3string;
				targetFile = option3File;
			}
		option1.BroadcastMessage("DoChangeTexture", option1File + option1string);
		option2.BroadcastMessage("DoChangeTexture", option2File + option2string);
		option3.BroadcastMessage("DoChangeTexture", option3File + option3string);
		target.BroadcastMessage("DoChangeTexture", targetFile + targetString);

		
		
		
		
	}
	
}
