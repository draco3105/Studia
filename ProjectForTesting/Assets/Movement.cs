using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 0.2f;

    private float speedMultiplier = 1.0f;
    private bool IsSpeedIncreasing = false;

    private Path path;
    private int nodeId = 0;
    private Vector3 destination;

    private Vector3 startPosition;
    private float timer = 0;
    
	void Start ()
    {
        path = FindObjectOfType<Path>();
        //startPosition = transform.position;
        SetNextDestination();

    }
	
	void Update ()
    {
        MovementAlongPath();
        //transform.Translate(movementSpeed * speedMultiplier, 0, 0);
        //Debug.Log(movementSpeed * speedMultiplier);
    }

    void MovementAlongPath()
    {
        timer += Time.deltaTime * (movementSpeed * speedMultiplier);
        if (transform.position != destination)
            transform.position = Vector3.Lerp(startPosition, destination, timer / (Vector3.Distance(startPosition, destination)));
        else if (nodeId < path.PathNodes.Count - 1)
        {
            nodeId++;
            SetNextDestination();
        }
    }

    void SetNextDestination()
    {
        timer = 0;
        startPosition = transform.position;
        destination = path.PathNodes[nodeId].transform.position;
    }

    public void IncreaseSpeed()
    {
        speedMultiplier = 2.0f;
    }
    public void DecreaseSpeed()
    {
        speedMultiplier = 0.5f;
    }
    public void StopChangingSpeed()
    {
        speedMultiplier = 1.0f;
    }
    public void ChangeSpeed(float multiplier)
    {
        if (multiplier == speedMultiplier)
            speedMultiplier = 1.0f;
        else
            speedMultiplier = multiplier;
    }
}
