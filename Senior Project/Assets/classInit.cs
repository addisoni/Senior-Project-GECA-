using UnityEngine;
using System.Collections;



public class classInit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

What I understand so far, still learning/trying to understand C#.


namespace mainCube
{
	public struct cubeFace
	{
		public int A;
		public int B;
		public int C;
		public int D;
	}
	public class cubeBuilder
	{
		public string Cubename { get; set; }
		public Vector[] cubeVertices {get; private set;}
		public Face[] cubeFaces {get; private set;}
		public Vector[] Position {get; set; }
	}
}
// Only called simple class... expand next meeting.
//Draw cube TBD