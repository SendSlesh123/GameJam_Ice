using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    bool damage = false;
    public Slider healthBar;
    public UI ui;
    private void Start()
    {
        healthBar.value = health;
    }
    public void StartDamage()
    {
        if (!damage)
        {
            StartCoroutine(Damage());
            damage = true;
        }
    }
    public void StopDamage()
    {
        if (damage)
        {
            StopAllCoroutines();
            damage = false;
        }
    }
    public IEnumerator Damage()
    {
        while (health > 0)
        {
            health--;
            healthBar.value = health;
            yield return new WaitForSeconds(1f);
            
        }
        if (health == 0)
        {
            Destroy(gameObject);
        } 
    }

    private void OnDestroy()
    {
        ui.ShowLosePanel();
    }
}
