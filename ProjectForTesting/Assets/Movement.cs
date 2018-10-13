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

    
	void Start ()
    {
        
	}
	
	void Update ()
    {
        transform.Translate(movementSpeed * speedMultiplier, 0, 0);
        Debug.Log(movementSpeed * speedMultiplier);
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
}
