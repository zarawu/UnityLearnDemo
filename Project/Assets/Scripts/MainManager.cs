using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	private string descInfo;
	// Use this for initialization
	void Start () {
		descInfo = "工程说明：每个Scene对应一个练习项，在OnGUI()中给出相应的button链接到对应Scene";
	}
	
	void OnGUI(){
		GUI.TextArea (new Rect (350, 20, 200, 300),descInfo);
		if (GUI.Button (new Rect (20, 20, 120, 40), "AnimatorScene")) {
			Application.LoadLevel("AnimatorScene");
		}
	}
}
