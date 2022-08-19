using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseContoller : MonoBehaviour
{
    [SerializeField]
    private int health;
    [SerializeField]
    private Text hpBar;
    void Update()
    {
        hpBar.text = health.ToString();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
            Die();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("On Enter");
        /*if(other.tag == "Common")
            health -= 1;
        if(other.tag == "Speedy")
            health -= 2;
        if(other.tag == "Healthy")
            health -= 5;*/
    }

    void Die()
    {
        if(health == 0)
            SceneManager.LoadScene(0);
    }
}
