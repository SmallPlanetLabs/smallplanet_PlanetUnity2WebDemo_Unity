
using UnityEngine;
using System.Collections;

public class WebEditorController : MonoBehaviour, IPUCode {


	public void Start() {
	
		string xmlPath = PlanetUnityGameObject.currentGameObject.xmlPath;
		string xml = PlanetUnityResourceCache.GetTextFile (xmlPath);

		#if UNITY_WEBPLAYER && !UNITY_EDITOR
		Application.ExternalCall( "UpdateXML", xml );
		#endif
	}

	public void XMLDidChange(string newXML) {
		PlanetUnityGameObject.ScheduleTask(new Task(delegate
			{
				PlanetUnityGameObject.currentGameObject.LoadCanvasXML(newXML);
			}));
	}

	public void ButtonClicked() {
		#if UNITY_WEBPLAYER && !UNITY_EDITOR
		Application.ExternalCall( "Alert", "Button Clicked!" );
		#endif
	}

	public void InputFieldChanged(Hashtable args) {
		PUInputField field = args ["sender"] as PUInputField;

		if (field != null) {

			Debug.Log ("You entered \""+field.field.value+"\"");

			#if UNITY_WEBPLAYER && !UNITY_EDITOR
			Application.ExternalCall( "Alert", "You entered \""+field.field.value+"\"" );
			#endif
		}
	}

}
