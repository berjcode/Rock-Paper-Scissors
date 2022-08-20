using UnityEngine;
using UnityEngine.UI;

public class BattleAreaController:MonoBehaviour
{
   [SerializeField] private Image playerImage;
    [SerializeField] Image enemyImage;
   [SerializeField] Text resultText;


    public void Populate(Sprite player, Sprite enemy,ResultState state)
    {
        gameObject.SetActive(true);
        playerImage.sprite = player;
        enemyImage.sprite = enemy;
       
        resultText.text =state.ToString();
    }


    public enum ResultState
    {
        Draw,win,Lose
    }
}
