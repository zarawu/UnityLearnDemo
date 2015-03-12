using UnityEngine;
using System.Collections;

public class MeshTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.AddComponent("MeshRenderer");
		gameObject.AddComponent("MeshFilter");

		GetComponent<MeshRenderer>().material.color =Color.green;
		GetComponent<MeshRenderer>().material.shader = Shader.Find("Transparent/Diffuse");
		Mesh mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;

//		Vector3[] newVertices = new Vector3[3];
//		newVertices[0] = new Vector3(0, 0, 0);
//		newVertices[1] = new Vector3(0, 3, 0);
//		newVertices[2] = new Vector3(3, 0, 0);
//		mesh.vertices = newVertices;
//		int[] newTriangles = new int[3]{2, 0, 1};
//		mesh.triangles = newTriangles;

		Vector3[] newVertices = new Vector3[4];
		newVertices[0] = new Vector3(0, 0, 0);
		newVertices[1] = new Vector3(0, 3, 0);
		newVertices[2] = new Vector3(3, 3, 0);
		newVertices[3] = new Vector3(3, 0, 0);
		mesh.vertices = newVertices;
		int[] newTriangles = new int[6]{0, 1, 2, 1, 2, 3};
		mesh.triangles = newTriangles;

	}
	

}
