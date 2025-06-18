using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorStript : MonoBehaviour
{
    public float health = 10;

    private bool isMelt = false;
    [SerializeField] GameObject iceCube;
    [SerializeField] GameObject waterCube;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!isMelt)
            {
                health -= 0.1f;
                if (health < 0)
                {
                    // Destroy(gameObject);
                    Melt();
                    isMelt = true;
                }
            }
            else
            {
                other.GetComponent<PlayerHealth>().StartDamage();
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isMelt)
            {
                other.GetComponent<PlayerHealth>().StartDamage();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isMelt)
            {
                other.GetComponent<PlayerHealth>().StopDamage();
            }
            else
            {
                Melt();
                isMelt = true;
            }
        }
    }

    void Melt()
    {
        waterCube.SetActive(true);
        iceCube.SetActive(false);
        gameObject.GetComponent<AudioSource>().Play();
        FinishScript.singleton.floorStripts.Remove(this);
    }
}
