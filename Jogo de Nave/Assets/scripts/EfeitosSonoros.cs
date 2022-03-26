using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitosSonoros : MonoBehaviour
{
    public static EfeitosSonoros instance;

    public AudioSource somDeExplosao;
    public AudioSource somDeImpactoLaser;
    public AudioSource somDoLaser;

    private void Awake()
    {
        instance = this;
    }

}
