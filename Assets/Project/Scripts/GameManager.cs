using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject player;

    public void checkpointTriggered()
    {
        //completeLevelUI.SetActive(true);
    }

    public void obstacleTriggered()
    {
        completeLevelUI.SetActive(true);
    }

    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("End Game");
            Invoke("restartFromCheckpoint", restartDelay);
        }
    }


    void restartFromCheckpoint()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
       
    }
}
