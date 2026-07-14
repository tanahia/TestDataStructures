using UnityEngine;

public class LinearSearch : MonoBehaviour
{
    [SerializeField] GrabInput input;
   void Awake()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void LinearSearchMethod()
    {
       string key = input.HandOverInput();
        Debug.Log("Input: " + key);
    }
    
   
}
