using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TYPE
{
   Speed,
   Scale,
}

public enum Intensity
{
    Low,
    Middle,
    High,
}

[CreateAssetMenu(fileName = "newSkill", menuName = "Skill")]
public class Skill : ScriptableObject
{
    public string Name;
    public string Descrption;
    public TYPE Type;
    public Intensity Intensity;
}