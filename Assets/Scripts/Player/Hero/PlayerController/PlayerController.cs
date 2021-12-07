using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
	public float playerMovementSpeed = 10f;

	private bool playerIsMoving;
	private Vector2 lastClickedPosition;

	private void Update()
	{
		HandlePlayerMovement();
	}
	
	public void HandlePlayerMovement()
	{
		if (Input.GetMouseButton(0))
		{
			lastClickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			playerIsMoving = true;
		}

		if (playerIsMoving && (Vector2)transform.position != lastClickedPosition)
		{
			float step = playerMovementSpeed * Time.deltaTime;
			transform.position = Vector2.MoveTowards(transform.position, lastClickedPosition, step);
		}
		else { playerIsMoving = false; }
	}
}
