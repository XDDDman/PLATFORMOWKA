using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextLevel : MonoBehaviour
{
    public Player_Death Player_Death;

    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            Player_Death.Reset();
        }
    }
}