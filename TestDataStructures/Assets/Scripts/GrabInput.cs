using UnityEngine;

public class GrabInput : MonoBehaviour
{
    [SerializeField] private string inputText;
    public void GrabInputFromField(string input)
    {
        inputText = input;
       
    }
    public string HandOverInput()
    {
        return inputText;
    }
    
}
