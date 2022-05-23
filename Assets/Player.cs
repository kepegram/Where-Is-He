using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public int maxStamina;
    public Image Stamina;
    public float StaminaIncreasedPerSecond;
    public Text StaminaText;
    public float UpdatedStamina;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
        StaminaIncreasedPerSecond = 1f;
        maxStamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(20);
            if (currentHealth <= 0f);
            {
                SceneManager.LoadScene("End");
            }
        }

        UpdatedStamina += StaminaIncreasedPerSecond * Time.deltaTime;
        Stamina.fillAmount = UpdatedStamina / maxStamina;

        StaminaText.text = (int)UpdatedStamina + " ";

        if(UpdatedStamina >= maxStamina)
        {
            UpdatedStamina = maxStamina;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
