using UnityEngine;

public class TestRandomGen : MonoBehaviour {

	RandomNameGen genScript;

	// Use this for initialization
	void Start () {
		//Get the RandomNameGen script component ready for use.
		genScript = GetComponent<RandomNameGen>();

		//print the outputs of randomly generated names to the console.
		Debug.Log(string.Format("Random Male Name Gen: \n{0} {1} {2}", genScript.GenerateFirstNameMale(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
		Debug.Log(string.Format("Random Female Name Gen: \n{0} {1} {2}", genScript.GenerateFirstNameFemale(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
		Debug.Log(string.Format("Random Name Gen: \n{0} {1} {2}", genScript.GenerateFirstName(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
		Debug.Log(string.Format("Random Place: \n{0}", genScript.GeneratePlace()));
	}

}
