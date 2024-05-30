using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;

public class achvmntCuatro : MonoBehaviour
{
    [SerializeField] private GameObject boss;
    private Health bossHealth;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth = boss.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bossHealth.CurrentHealth <= 0)
       {
            MMAchievementManager.UnlockAchievement("Boss");
       }
    }
}
