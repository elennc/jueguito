using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;

public class AchievementVolar : MonoBehaviour, MMEventListener<MMDamageTakenEvent>, MMEventListener<PickableItemEvent>
{
    
    public int indexScene;
    private int killCount = 0;
    public int killAchivement = 3;
    [SerializeField] private GameObject boss;
    [SerializeField] private GameObject player;
    private Health bossHealth;
    private Health playerHealth;

    void Start(){
        indexScene = SceneManager.GetActiveScene().buildIndex;
        
       bossHealth = boss.GetComponent<Health>();
        playerHealth = player.GetComponent<Health>();
    }

    
    void OnEnable()
    {
        this.MMEventStartListening<MMDamageTakenEvent>();
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<MMDamageTakenEvent>();
        this.MMEventStopListening<PickableItemEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MMAchievementManager.UnlockAchievement("Vuela");
            Debug.Log("Funciona pleek");
        }

        /*if(indexScene == 2){
            Debug.Log("Eso Tilina");
        }*/

       
        if(killCount >= killAchivement)
        {
            MMAchievementManager.UnlockAchievement("Incecticida");
            Debug.Log("Logro");
        }

       if(bossHealth.CurrentHealth <= 0)
       {
            MMAchievementManager.UnlockAchievement("Boss");
       } 

       if(playerHealth.CurrentHealth <= 0)
       {
            MMAchievementManager.UnlockAchievement("Reflect");
       }
       
    }

    public void OnMMEvent(MMDamageTakenEvent damageEvent)
    {
        // Verificar si el objeto que recibió daño tiene el tag "Enemy" y si su salud es menor o igual a 0
        if (damageEvent.AffectedHealth.CompareTag("Enemy"))
        {
            killCount++;
        }  
        Debug.Log("Kill count :"+ killCount); 

        

     
    }

     public void OnMMEvent(PickableItemEvent m)
    {
        
        if(m.PickedItem.tag == "Inmunidad")
        {
            MMAchievementManager.UnlockAchievement("Pollinator");
            Debug.Log("achivement Inmunidad");
        }
    }

   

   

    

}
