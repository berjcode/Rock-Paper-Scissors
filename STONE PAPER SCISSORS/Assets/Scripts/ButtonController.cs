using UnityEngine;
using UnityEngine.UI;

public class ButtonController:MonoBehaviour
{
    [SerializeField] private Image image;
    private ElementController _controller;
    public void Populate(ElementController controller)
    {
        _controller = controller;
        image.sprite = controller.mySprite;
    }

    public void onClick()
    {
        GameManager.Instance.SelectElemet(_controller);
        GameManager.Instance.RandomEnemy();
        GameManager.Instance.Battle();
    }
}

