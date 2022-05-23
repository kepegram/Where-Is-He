using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectDamage : MonoBehaviour
{
    public bool beInFire;
    public bool stopDealDamage;
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (beInFire == true)
        {
            if (stopDealDamage == false)
            {
                stopDealDamage = true;
                StartCoroutine(DamageFromFire());
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Fire")
        {
            beInFire = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Fire")
        {
            beInFire = false;
        }
    }
    IEnumerator DamageFromFire()
    {
        yield return new WaitForSeconds(1);
        TakeDamage(20);
        yield return new WaitForSeconds(1);
        TakeDamage(20);
        yield return new WaitForSeconds(1);
        TakeDamage(20);
        yield return new WaitForSeconds(1);
        TakeDamage(20);
        yield return new WaitForSeconds(1);
        TakeDamage(20);
        if (currentHealth <= 0f);
        {
            SceneManager.LoadScene("End");
        }
        stopDealDamage = false;
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}


