using UnityEngine;

public class endTrigger : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		GameManager.gameManager.CompleteLevel();
	}
}
