using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private bool isMovingOnX = false;
    [SerializeField]
    private float movementRange = 2.0f;
    [SerializeField]
    private float movementSpeed = 0.2f;

    private float speedMultiplier = 1.0f;

    private Vector3 destination;
    private Vector3 startPosition;
    private float timer = 0;
    private int directionCoefficient = 1;

    // Use this for initialization
    void Start ()
    {
        startPosition = transform.localPosition;
        if (isMovingOnX)
        {
            destination.x += transform.localPosition.x - (movementRange / 2);
            destination.z += transform.localPosition.z;
        }
        else
        {
            destination.z += transform.localPosition.z - (movementRange / 2);
            destination.x += transform.localPosition.x;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime * (movementSpeed * speedMultiplier);
        if (transform.localPosition != destination)
            transform.localPosition = Vector3.Lerp(startPosition, destination, timer / (Vector3.Distance(startPosition, destination)));
        else
        {
            Debug.Log("AAA");
            if (isMovingOnX)
                destination.x += directionCoefficient * movementRange;
            else
                destination.z += directionCoefficient * movementRange;
            timer = 0;
            startPosition = transform.localPosition;
            directionCoefficient *= -1;
        }

    }
}
