
using UnityEngine;

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

}
