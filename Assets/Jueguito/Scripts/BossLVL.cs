using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class BossLVL : MonoBehaviour
{
    [SerializeField] private GameObject puerta;
    [SerializeField] private GameObject boss;
    private Health bossHealth;

    // Start is called before the first frame update
    void Start()
    {
        if(puerta != null)
        {
            puerta.SetActive(false);
        }

        bossHealth = boss.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bossHealth.CurrentHealth <= 0)
        {
            puerta.SetActive(true);
        }   
    }
}
