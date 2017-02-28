using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class RandomNameGen : MonoBehaviour {
	
	private enum Gender {
		Male,
		Female,
		None
	}
	[SerializeField]
	private Gender genderType;
	private List<String> fileContent = new List<String>();

	public string textFile;

	// Use this for initialization
	void Start () {

	}

	public string GenerateFirstNameMale() {
		fileContent.Clear();
		LoadFile("NAMES-M.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public string GenerateFirstNameFemale() {
		fileContent.Clear();
		LoadFile("NAMES-F.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public string GenerateFirstName() {
		fileContent.Clear();
		LoadFile("NAMES-F.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public string GenerateLastName() {
		fileContent.Clear();
		LoadFile("NAMES.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public string GenerateMiddleName() {
		fileContent.Clear();
		LoadFile("NAMES.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public string GeneratePlace() {
		fileContent.Clear();
		LoadFile("PLACES.txt");

		UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
		int genInt = UnityEngine.Random.Range(0, fileContent.Count);
		return fileContent[genInt]; 
	}

	public void LoadFile(string fileName) {
		try {
			string curLine;
			StreamReader newReader = new StreamReader("Assets/NamePlaceGen-Unity/Resources/" + fileName);

			using (newReader) {
				do {
					curLine = newReader.ReadLine();
					fileContent.Add(curLine);
				}
				while(curLine != null);
				newReader.Close();
			}
		}
		catch(Exception e) {
			Debug.Log(string.Format("{0}\n", e.ToString()));
		}
	}

	public void DisplayFileContents() {
		foreach(string item in fileContent) {
			Debug.Log(item);
		}
	}

}
