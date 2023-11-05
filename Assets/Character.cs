using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCharacter", menuName = "Character")]
public class Character : ScriptableObject
{
    public string Name;
    public string Descrption;
    public string Agility;
    public float Health;
    public Sprite Portrait;
}
