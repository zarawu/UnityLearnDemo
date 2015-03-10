using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour {

	private Light light;
	private float add = 0.1f;
	
	void Start () {
		light = GetComponent<Light>();
	}

	void Update () {
		light.intensity += add;
		if(light.intensity > 6.0f) {
			add = -add;
		}else if(light.intensity < 5.0f) {
			add = -add;
		}
	}
}