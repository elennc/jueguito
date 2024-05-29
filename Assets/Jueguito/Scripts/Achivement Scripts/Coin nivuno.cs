using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class Coinnivuno : MonoBehaviour , MMEventListener<PickableItemEvent>
{
    public int coinCounter = 0;
    public int coinAchivement = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(coinCounter >= coinAchivement)
        {
            MMAchievementManager.UnlockAchievement("Hoarder");
        }
    }

    public void OnMMEvent(PickableItemEvent coin)
    {
        
        coinCounter++;
    }
}
