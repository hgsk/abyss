using UnityEngine;
using System.Collections;

public class renderSettingController : MonoBehaviour {
	public int deepdepth = 300;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//TODO better color 
		RenderSettings.fogColor = new Color(0,0,(gameObject.transform.position.y-this.deepdepth)/this.deepdepth);
	}
}
