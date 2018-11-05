using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> PathNodes { get; set; } // = new List<Transform>();
    [SerializeField]
    private Movement playerMovement;

    // Use this for initialization
    void Start ()
    {
        PathNodes = new List<Transform>();
        PathNodes.AddRange(GetComponentsInChildren<Transform>());
        PathNodes.RemoveAt(0);
        //foreach( var node in PathNodes)
        //    Debug.Log(node);
        playerMovement.SetFirstDestination();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
