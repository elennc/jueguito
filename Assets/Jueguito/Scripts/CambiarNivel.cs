using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class CambiarNivel : MonoBehaviour
{
    public void OnCambiarNivel()
    {
        MMSceneLoadingManager.LoadScene("Nivel3");
    }
}
