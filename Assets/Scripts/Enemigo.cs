using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int amount);
}
public class Enemigo : MonoBehaviour
{
    public int vida = 100;

    public void TakeDamage(int amount)
    {
        vida -= amount;
        Debug.Log("El enemigo recibio" + amount + "de daño");

        if (vida < 0) {
            Muerte();
        }
    }

    protected void Muerte()
    {
        Destroy(gameObject);
        Debug.Log("F");
    }
}
