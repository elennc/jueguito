using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class BotonInstruc : MonoBehaviour
{
    public void OnClickInstruc()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones"); ;

    }
}
