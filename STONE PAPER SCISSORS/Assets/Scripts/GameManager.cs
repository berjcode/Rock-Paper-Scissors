using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    private ElementController player;
    private ElementController enemy;


    public BattleAreaController battleArea;
    

     [SerializeField]  private List<ElementController> listElements;
     [SerializeField] private List<ButtonController> listButton;

    private void Awake()
    {
        Instance = this;
    }

    public void SelectElemet(ElementController controller)
    {
        player = controller;
    }

   public void RandomEnemy()
    {
        var index = Random.Range(0,listElements.Count);
        enemy = listElements[index];
    }
    private void Start()
    {
        for(int i = 0; i < listButton.Count; i++)
        {
            var button = listButton[i];
            var element= listElements[i];
            button.Populate(element);

        }
    }

    [ContextMenu(nameof(Battle))]
    public void Battle()
    {
        var currentState = BattleAreaController.ResultState.Draw;
         var contains = player.weakTypes.Contains(enemy.myType);
        currentState = contains ? BattleAreaController.ResultState.Lose : BattleAreaController.ResultState.win;


        if (player.myType == enemy.myType)
            currentState = BattleAreaController.ResultState.Draw;
        

        battleArea.Populate(player.mySprite, enemy.mySprite,currentState);
    }
    
}
