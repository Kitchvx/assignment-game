using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackText : MonoBehaviour
{
    public static Text GemsMessage;
    
    // Start is called before the first frame update
    void Start()
    {
        GemsMessage = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
