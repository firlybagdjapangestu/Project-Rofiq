using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stone", menuName = "Stone Data", order = 1)]
public class StoneData : ScriptableObject
{
    public Sprite stoneImage;
    public string stoneName;
    [TextArea(3, 5)]
    public string stoneDescription;
    public AudioClip stoneSoundDescription;

    public string namaBatu;
    [TextArea(3, 5)]
    public string deskripsiBatu;
    public AudioClip suaraPenjelasanBatu;

    public GameObject stonePrefabs;
}
