using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

namespace JJ_RandomNameGen {
	public class RandomNamePlaceGen {

		//List will contain the contents of the name files.
		private List<String> fileContent = new List<String>();

		//Generates Male First Names...
		public string GenerateFirstNameMale() {
			fileContent.Clear();
			LoadFile("NAMES-M.txt");

			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Generates Female First Names...
		public string GenerateFirstNameFemale() {
			fileContent.Clear();
			LoadFile("NAMES-F.txt");

			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Generates Other First Names...
		public string GenerateFirstName() {
			fileContent.Clear();
			
			UnityEngine.Random randomVal = new Random();
			int choice = randomVal.Next(0, 2);
			if(choice == 0)
				LoadFile("NAMES-F.txt");
			else
				LoadFile("NAMES-M.txt");
			
			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Generates Last Names...
		public string GenerateLastName() {
			fileContent.Clear();
			LoadFile("NAMES.txt");

			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Generates Middle Names...
		public string GenerateMiddleName() {
			fileContent.Clear();
			LoadFile("NAMES.txt");

			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Generates Place Names...
		public string GeneratePlace() {
			fileContent.Clear();
			LoadFile("PLACES.txt");

			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
			int genInt = UnityEngine.Random.Range(0, fileContent.Count);
			return fileContent[genInt]; 
		}

		//Reads and stores contents of file in a list...
		public void LoadFile(string fileName) {
			try {
				string curLine;
				//The name files must be in this specific folder to work...
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

		//Debug method to display stored file content...
		public void DisplayFileContents() {
			foreach(string item in fileContent) {
				Debug.Log(item);
			}
		}

	}
}
