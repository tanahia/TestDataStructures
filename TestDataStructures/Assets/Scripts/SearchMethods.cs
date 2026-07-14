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
    public int BinarySearch()
    {
        string key = input.HandOverInput();
        int left = 0;
        int right = inventoryItems.Length - 1;

        // Array is needed to be soted for binary search
        System.Array.Sort(inventoryItems);

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int comparison = string.Compare(inventoryItems[mid], key, System.StringComparison.Ordinal);

            if (comparison == 0)
                return mid;
            else if (comparison > 0)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
    public void DisplayBinarySearchResult()
    {
        int result = BinarySearch();
        if (result != -1)
            Debug.Log("Item found: " + inventoryItems[result]);
        else
            Debug.Log("Item not found");
    }
}
