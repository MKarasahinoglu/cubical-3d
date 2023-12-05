using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class obstacleMovement : MonoBehaviour
{
	private Vector3 initialPosition;
	public Vector3 destination;
	[Range(0,1)] public float speed=1f;
	void Start()
	{
		initialPosition = transform.position;
		destination += initialPosition;
	}
	void FixedUpdate()
    {
		
		float time = Mathf.PingPong(Time.time*speed, 1);
		transform.position=Vector3.Lerp(initialPosition, destination, time);
    }
}
