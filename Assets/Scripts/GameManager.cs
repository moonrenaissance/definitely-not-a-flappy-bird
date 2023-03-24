using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private Player player;
    private Spawner spawner;

    public GameObject playButton;
    public GameObject gameOver;
    public GameObject GetReady;
    public Text scoreText;
    public int score { get; private set; }

    private void Awake() 
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();

        gameOver.SetActive(false);
        GetReady.SetActive(true);
        Pause();
    }

    public void Play() 
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        GetReady.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        PipesMovement[] pipes = FindObjectsOfType<PipesMovement>();

        for (int i = 0; i < pipes.Length; i++) 
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause() 
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver() 
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore() 
    {
        score++;
        scoreText.text = score.ToString();
    }
}
