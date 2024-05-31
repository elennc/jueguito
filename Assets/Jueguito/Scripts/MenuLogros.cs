using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

[AddComponentMenu("More Mountains/Tools/Achievements/MMAchievementDisplayer")]
public class MenuLogros : MonoBehaviour, MMEventListener<MMAchievementUnlockedEvent>
{
    public MMAchievementDisplayItem AchievementDisplayPrefab;
    public MMAchievementDisplayItem logro1;
	public List<MMAchievementDisplayItem> Achievements;
	public MMAchievementList listaLogros;

	//public int conIn;
	public int cont;
	public int tipo;
	private void Start() {
		//logro1.Title.text = listaLogros.Achievements.IndexOf("TenEnemies").Title.text;
		foreach (MMAchievement achievement in MMAchievementManager.AchievementsList){
			if(tipo==0){
				if(cont<5){
			GameObject instance = (GameObject)Instantiate(AchievementDisplayPrefab.gameObject);
			instance.transform.SetParent(this.transform,false);

			MMAchievementDisplayItem achievementDisplay = instance.GetComponent<MMAchievementDisplayItem> ();
			achievementDisplay.Title.text = achievement.Title;
			achievementDisplay.Description.text = achievement.Description;
			if (achievement.UnlockedStatus){
			achievementDisplay.Icon.sprite = achievement.UnlockedImage;}
			else{achievementDisplay.Icon.sprite = achievement.LockedImage;}
			if (achievement.AchievementType == AchievementTypes.Progress)
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(true);
			}
			else
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(false);
			}
			}
			}
			if(tipo==1){
				if(cont>=5){
			GameObject instance = (GameObject)Instantiate(AchievementDisplayPrefab.gameObject);
			instance.transform.SetParent(this.transform,false);

			MMAchievementDisplayItem achievementDisplay = instance.GetComponent<MMAchievementDisplayItem> ();
			achievementDisplay.Title.text = achievement.Title;
			achievementDisplay.Description.text = achievement.Description;
			if (achievement.UnlockedStatus){
			achievementDisplay.Icon.sprite = achievement.UnlockedImage;}
			else{achievementDisplay.Icon.sprite = achievement.LockedImage;}
			if (achievement.AchievementType == AchievementTypes.Progress)
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(true);
			}
			else
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(false);
			}
			}
			}
			cont++;
    	}

		
	}

	private void Update() {
		
	}
	

    public void DisplayAchievement(MMAchievement achievement){
        GameObject instance = (GameObject)Instantiate(AchievementDisplayPrefab.gameObject);
		instance.transform.SetParent(this.transform,false);

		// we get the achievement displayer
			MMAchievementDisplayItem achievementDisplay = instance.GetComponent<MMAchievementDisplayItem> ();

			// we fill our achievement
			achievementDisplay.Title.text = achievement.Title;
			achievementDisplay.Description.text = achievement.Description;
			achievementDisplay.Icon.sprite = achievement.UnlockedImage;
			if (achievement.AchievementType == AchievementTypes.Progress)
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(true);
			}
			else
			{
				achievementDisplay.ProgressBarDisplay.gameObject.SetActive(false);
			}
    }

    public virtual void OnMMEvent(MMAchievementUnlockedEvent achievementUnlockedEvent)
		{
			//StartCoroutine(DisplayAchievement (achievementUnlockedEvent.Achievement));
            DisplayAchievement (achievementUnlockedEvent.Achievement);
			Debug.Log("Se avanzo en: " + achievementUnlockedEvent.Achievement.Title);
		}

		/// <summary>
		/// On enable, we start listening for unlocked achievements
		/// </summary>
		protected virtual void OnEnable()
		{
			this.MMEventStartListening<MMAchievementUnlockedEvent>();
			//_achievementFadeOutWFS = new WaitForSeconds (AchievementFadeDuration + AchievementDisplayDuration);
		
		}

		/// <summary>
		/// On disable, we stop listening for unlocked achievements
		/// </summary>
		protected virtual void OnDisable()
		{
			this.MMEventStopListening<MMAchievementUnlockedEvent>();
		}

    
}
