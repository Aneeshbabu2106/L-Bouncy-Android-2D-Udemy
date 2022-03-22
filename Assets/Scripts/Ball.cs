using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnMouseDown() {

        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
        
    }
}
