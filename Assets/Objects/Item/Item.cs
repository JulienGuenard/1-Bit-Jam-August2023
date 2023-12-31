using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Recipe
{
    public List<Item> recipeList;
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    public string itemName;

    [TextArea] public string itemDescription;
    public int alignmentModifier;
    public Sprite sprite;
    public bool isIngredient;

    public List<Recipe> allRecipeList;
}