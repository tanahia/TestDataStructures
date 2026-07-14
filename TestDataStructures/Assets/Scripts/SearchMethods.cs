using UnityEngine;

public class SearchMethods : MonoBehaviour
{
    [SerializeField] GrabInput input;
    private static string[] inventoryItems = { "Sword", "Shield", "Healing Potion", "Cheese" };

    public void LinearSearch()
    {
        string key = input.HandOverInput();
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            if (inventoryItems[i] == key)
            {
                Debug.Log("Item found: " + inventoryItems[i]);
                return;
            }
            else
                Debug.Log("Item not found");
        }
    }
}
