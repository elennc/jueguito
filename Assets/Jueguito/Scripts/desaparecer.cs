using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    float timerOnScreen;

    void Start() {
        gameObject.SetActive(false);
    }

    public void ActivarEG()
    {
        gameObject.SetActive(true);
        timerOnScreen = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerOnScreen -= Time.deltaTime;
        if (timerOnScreen<0)
        {
            gameObject.SetActive(false);
        }
    }
}
