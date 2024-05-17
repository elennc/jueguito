using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class AchievementVolar : MonoBehaviour
{

    public int indexScene;

    void Start(){
        indexScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MMAchievementManager.UnlockAchievement("Vuela");
        }

        if(indexScene == 2){
            Debug.Log("Eso Tilina");
        }
    }
}
