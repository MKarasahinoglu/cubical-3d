using UnityEngine;

public class collisionScript : MonoBehaviour
{
	public playerMovement playerMovement_;
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag=="obstacle")
		{
			playerMovement_.enabled = false;
			GameManager.gameManager.EndGame();
		}
		if(collision.collider.name=="Ground")
		{
			playerMovement_.canJump = true;
		}
	}

}
