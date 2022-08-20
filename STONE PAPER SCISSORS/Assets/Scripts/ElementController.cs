using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Create ElementController", fileName ="ElementController",order =0)]
public class ElementController:ScriptableObject
{
    public Sprite mySprite;
    public ElementType myType;
    public List<ElementType> weakTypes;
    
}

