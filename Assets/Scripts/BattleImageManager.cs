using UnityEngine;

public class BattleImageManager : MonoBehaviour
{
    public GameObject opponent1Image;
    public GameObject opponent2Image;
    public GameObject opponent3Image;
    public GameObject environmentTavernImage;
    public GameObject environmentTheaterImage;
    public GameObject enemyPortrait1;
    public GameObject enemyPortrait2;
    public GameObject enemyPortrait3;

    private void Start()
    {
        int currentBattle = GameManager.Instance.currentBattle;
        Debug.Log("CURRENT BATTLE2: " + currentBattle);
        switch (currentBattle)
        {
            case 1:
                ToggleBattle1(true);
                ToggleBattle2(false);
                ToggleBattle3(false);
                environmentTavernImage.SetActive(true);
                break;
            case 2:
                ToggleBattle1(false);
                ToggleBattle2(true);
                ToggleBattle3(false);
                environmentTavernImage.SetActive(true);
                break;
            case 3:
                ToggleBattle1(false);
                ToggleBattle2(false);
                ToggleBattle3(true);
                environmentTavernImage.SetActive(false);
                break;
            default:
                Debug.LogWarning("Invalid battle number: " + currentBattle);
                break;
        }
    }

    public void ToggleBattle1(bool should_display)
    {
        opponent1Image.SetActive(should_display);
        enemyPortrait1.SetActive(should_display);
        
    }

    public void ToggleBattle2(bool should_display)
    {
        opponent2Image.SetActive(should_display);
        enemyPortrait2.SetActive(should_display);
    }

    public void ToggleBattle3(bool should_display)
    {
        opponent3Image.SetActive(should_display);
        enemyPortrait3.SetActive(should_display);
        environmentTheaterImage.SetActive(should_display);
    }
}
