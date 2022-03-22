using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    public GameObject restartButton;

    public void ScoreUp()
    {
        score++;
        if(score>=3)
        {
            Win();
        }
    }
    private void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
