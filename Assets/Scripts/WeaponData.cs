using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewWeaponData", menuName = "Weapon Data", order = 0)]

public class WeaponData : ScriptableObject
{
    public string NombreArma;
    public int daño;
    public float rango;
}
