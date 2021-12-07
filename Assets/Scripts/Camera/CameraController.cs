using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    
    private void Update()
    {
        
    }

	private void FixedUpdate()
	{
        HandleCameraMovement();
    }

	private void HandleCameraMovement()
	{
        transform.position = new Vector3(player.transform.position.x + offset.x,
            player.transform.position.y + offset.y, player.transform.position.z + offset.z);
	}
}
