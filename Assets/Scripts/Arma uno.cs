using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armauno : MonoBehaviour
{
    public WeaponData weaponData;

    private void Start()
    {
        Debug.Log("nombre:" + weaponData.name);
        Debug.Log("daño" + weaponData.daño);
        Debug.Log("rango" + weaponData.rango);
    }

}
