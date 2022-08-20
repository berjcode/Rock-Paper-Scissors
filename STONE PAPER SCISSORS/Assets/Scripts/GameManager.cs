using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    private ElementController player;
    private ElementController enemy;


    public List<ElementController> listElements;
    public List<ButtonController> listButton;

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

        if(player.myType == enemy.myType)
        {
            Debug.Log("Draw");
            return;
        }
        var contains = player.weakTypes.Contains(enemy.myType);


        if (contains)
            Debug.Log($"Win pplayer => {enemy.myType} >{player.myType}");
        else
            Debug.Log($"Win Player 1 => {player.myType} > {enemy.myType}");


    }
    
}
