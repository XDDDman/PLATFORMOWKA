using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
    if(col.CompareTag("Instant death"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
