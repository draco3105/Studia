using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> PathNodes { get; set; } // = new List<Transform>();

    // Use this for initialization
    void Start ()
    {
        PathNodes = new List<Transform>();
        PathNodes.AddRange(GetComponentsInChildren<Transform>());
        PathNodes.RemoveAt(0);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
