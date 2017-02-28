using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandomGen : MonoBehaviour {

	RandomNameGen genScript;

	// Use this for initialization
	void Start () {
		genScript = GetComponent<RandomNameGen>();

		Debug.Log(string.Format("Random Male Name Gen: \n{0} {1} {2}", genScript.GenerateFirstNameMale(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
		Debug.Log(string.Format("Random Female Name Gen: \n{0} {1} {2}", genScript.GenerateFirstNameFemale(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
		Debug.Log(string.Format("Random Name Gen: \n{0} {1} {2}", genScript.GenerateFirstName(), genScript.GenerateMiddleName(), genScript.GenerateLastName()));
	}

}
