
using UnityEngine;
using System.Collections.Generic;
using System;

public class ToyHeader {

	public string title;

	public ToyHeader(string _title) {
		title = _title;
	}
}

public class ToyHeaderTableCell : PUTableCell {

	public PUText Title;

	public override string XmlPath() {
		return "main/toyHeader";
	}

	public override bool IsHeader() {
		return true;
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data) {		
		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data);

		ToyHeader header = cellData as ToyHeader;
		Title.text.text = header.title;
	}
}
