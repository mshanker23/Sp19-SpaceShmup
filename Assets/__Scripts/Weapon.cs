using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    none, //the defauls / no weapon
    blaster, //a simple blaser
    spread, //two shots simultaneously
    phaser, //[NI] shots that move in waves
    missile, //[NI] homeing misisles
    laser, //[NI] damage over time
    shield //raise shieldLevel
}

[System.Serializable]
public class WeaponDefinition
{
    public WeaponType type = WeaponType.none;
    public string letter;
    public Color color = Color.white;
    public GameObject projectilePrefab;
    public Color projectileColor = Color.white;
    public float damageOnHit = 0;
    public float continuousDamage = 0;
    public float delayBetweenShots = 0;
    public float velocity = 20;
}




public class Weapon: MonoBehaviour
{

}