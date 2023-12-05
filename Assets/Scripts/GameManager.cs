using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager gameManager;
	private bool isGameEnded = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;
	void Start()
	{
		if(gameManager == null)
		{
			gameManager = GetComponent<GameManager>();
		}
		
	}
	public void EndGame()
	{
		if(!isGameEnded)
		{
			isGameEnded = true;
			Invoke("restartGame", restartDelay);
		}
		
	}
	private void restartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		isGameEnded = false;
	}

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
		
	}

}
