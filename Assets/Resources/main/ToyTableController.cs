
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToyTableController : MonoBehaviour, IPUCode {

	public PUTable ToyTable;

	string randomLoremIpsum()
	{
		string lorem = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		int length = UnityEngine.Random.Range (0, lorem.Length - 20);
		return lorem.Substring (0, 20 + length);
	}

	public void Start() {

		List<object> allItems = new List<object> ();
		allItems.Add (new ToyHeader ("Robots"));
		allItems.Add (new Toy ("main/robot", randomLoremIpsum()));
		allItems.Add (new Toy ("main/robot", randomLoremIpsum()));
		allItems.Add (new Toy ("main/robot", randomLoremIpsum()));
		allItems.Add (new Toy ("main/robot", randomLoremIpsum()));
		allItems.Add (new Toy ("main/robot", randomLoremIpsum()));
		allItems.Add (new ToyHeader ("Dolls"));
		allItems.Add (new Toy ("main/doll", randomLoremIpsum()));
		allItems.Add (new Toy ("main/doll", randomLoremIpsum()));
		allItems.Add (new Toy ("main/doll", randomLoremIpsum()));
		allItems.Add (new Toy ("main/doll", randomLoremIpsum()));
		allItems.Add (new Toy ("main/doll", randomLoremIpsum()));
		allItems.Add (new ToyHeader ("Airplanes"));
		allItems.Add (new Toy ("main/airplane", randomLoremIpsum()));
		allItems.Add (new Toy ("main/airplane", randomLoremIpsum()));
		allItems.Add (new Toy ("main/airplane", randomLoremIpsum()));
		allItems.Add (new Toy ("main/airplane", randomLoremIpsum()));
		allItems.Add (new Toy ("main/airplane", randomLoremIpsum()));

		ToyTable.SetObjectList (allItems);
		ToyTable.ReloadTable ();
	}

}
