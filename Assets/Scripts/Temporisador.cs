using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporisador : MonoBehaviour
{
    public float tempo;
    public Button btnComecar;
    public SpriteRenderer image1;
    public SpriteRenderer image2;
    public SpriteRenderer image3;
    public SpriteRenderer image4;
    public SpriteRenderer image5;

    public float limiteTimeHistoria;
    public float limiteTime1;
    public float limiteTime2;
    public float limiteTime3;
    public float limiteTime4;
    public float limiteTime5;

    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= limiteTimeHistoria)
        {
            btnComecar.gameObject.SetActive(true);
        }
        if (tempo >= limiteTime1)
        {
            image1.gameObject.SetActive(true);
        }
        if (tempo >= limiteTime2)
        {
            image2.gameObject.SetActive(true);
        }
        if (tempo >= limiteTime3)
        {
            image3.gameObject.SetActive(true);
        }
        if (tempo >= limiteTime4)
        {
            image4.gameObject.SetActive(true);
        }
        if (tempo >= limiteTime5)
        {
            image5.gameObject.SetActive(true);
        }
    }
}
