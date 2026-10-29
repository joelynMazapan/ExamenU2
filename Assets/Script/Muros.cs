using UnityEngine;
using UnityEngine.SceneManagement;

public class Muros : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            Debug.Log("Game Over!");
            ReiniciarNivel();
        }
    }

    // Update is called once per frame
    void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

