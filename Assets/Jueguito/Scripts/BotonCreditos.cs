using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class BotonCreditos : MonoBehaviour
{
    public void OnClickCreditos()
    {
        MMSceneLoadingManager.LoadScene("Creditos"); ;

    }
}
