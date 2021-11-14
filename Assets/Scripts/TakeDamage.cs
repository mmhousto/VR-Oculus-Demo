using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private int health;

    private const int MAXHEALTH = 100;

    public TextMeshProUGUI healthText;

    private void Start()
    {
        health = MAXHEALTH;
        if(healthText)
            healthText.text = "Health: " + health.ToString();
    }

    private void Update()
    {
        if(healthText)
            healthText.text = "Health: " + health.ToString();

        if(health <= 0)
        {
            if(ScoreManager.score > PlayerPrefs.GetInt("HiScore", 0))
            {
                PlayerPrefs.SetInt("HiScore", ScoreManager.score);
            }
            GameManager.Instance.RestartGame();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            LoseHealth();
        }
    }

    private void LoseHealth()
    {
        health -= Random.Range(2, 11);
    }
}
