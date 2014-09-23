
using UnityEngine;
using System.Collections.Generic;
using System;

public class Toy {

	public string icon;
	public string content;

	public Toy(string _icon, string _content) {
		icon = _icon;
		content = _content;
	}
}

public class ToyTableCell : PUTableCell {

	public PUText Content;
	public PURawImage Icon;

	public override string XmlPath() {
		return "main/toyCell";
	}

	public override bool IsHeader() {
		return false;
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data) {

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data);

		Toy toy = cellData as Toy;
		Content.text.text = toy.content;

		Icon.LoadImageWithResourcePath (toy.icon);


		float height = Content.text.preferredHeight + 10;
		if (height < 90) {
			height = 90;
		}
		
		puGameObject.rectTransform.sizeDelta = new Vector2 (
			puGameObject.rectTransform.sizeDelta.x,
			height);
	}
}
