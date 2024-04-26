using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class CambiarNivel1 : MonoBehaviour
{
    public void OnCambiarNivel1()
    {
        MMSceneLoadingManager.LoadScene("Nivel2");
    }
}
