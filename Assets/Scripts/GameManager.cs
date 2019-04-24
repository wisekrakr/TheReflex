using UnityEngine;
using UnityEngine.SceneManagement;

    
public class GameManager : MonoBehaviour{

    private bool gameEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void GameOver()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
   
}
