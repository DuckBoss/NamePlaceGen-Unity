using UnityEngine;
using JJ_RandomNameGen;

public class TestRandomGen : MonoBehaviour {

	//Reference to RandomNamePlaceGen Script
	RandomNamePlaceGen genScript;

	private void Start () {
		//Get the RandomNamePlaceGen script component ready for use.
		genScript = new RandomNamePlaceGen();
	}

	private void Update() {
		//Generate new debugs everytime the left mouse button is clicked.
		if(Input.GetMouseButtonDown(0)) {
			GenerateDebugs();
		}
	}

	public void GenerateDebugs() {
		//Generate Male Name...
		string randomMaleFirstName = genScript.GenerateFirstNameMale();
		string randomMaleMiddleName = genScript.GenerateMiddleName();
		string randomMaleLastName = genScript.GenerateLastName();

		//Generate Female Name...
		string randomFemaleFirstName = genScript.GenerateFirstNameFemale();
		string randomFemaleMiddleName = genScript.GenerateMiddleName();
		string randomFemaleLastName = genScript.GenerateLastName();

		//Generate Any Name...
		string randomFirstName = genScript.GenerateFirstName();
		string randomMiddleName = genScript.GenerateMiddleName();
		string randomLastName = genScript.GenerateLastName();

		//Generate Place...
		string randomPlace = genScript.GeneratePlace();

		//Print the outputs of randomly generated names and places to the console.
		Debug.Log(string.Format("Random Male Name Gen: \n{0} {1} {2}", randomMaleFirstName, randomMaleMiddleName, randomMaleLastName));
		Debug.Log(string.Format("Random Female Name Gen: \n{0} {1} {2}", randomFemaleFirstName, randomFemaleMiddleName, randomFemaleLastName));
		Debug.Log(string.Format("Random Name Gen: \n{0} {1} {2}", randomFirstName, randomMiddleName, randomLastName));
		Debug.Log(string.Format("Random Place: \n{0}", randomPlace));

		Debug.ClearDeveloperConsole();
	}

}
