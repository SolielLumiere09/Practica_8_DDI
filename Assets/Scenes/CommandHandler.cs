using System;
using IBM.Watsson.Examples;
using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    public static Boolean JUMP_MIKU;
    public static Boolean RAINBOW_MIKU;
    public static Boolean DASH_MIKU;
    public static Boolean RAINBOW_ROAD_MIKU;
    public static Boolean STOP;
    public static Boolean DANCE_MIKU;
    public static Boolean ROLL_FAIL_MIKU;
    private ExampleStreaming speechListener;
    
    // Start is called before the first frame update
    void Start()
    {
        speechListener = GetComponent<ExampleStreaming>();
        
        if(speechListener == null)
            Debug.Log("NULL speedListener");
    }

    // Update is called once per frame
    void Update()
    {
        string command = speechListener.getCommand();

        ROLL_FAIL_MIKU = command.Equals("rolling");
        DANCE_MIKU = command.Equals("dancing");
        STOP = command.Equals("stop");
        JUMP_MIKU = command.Equals("jump");
        RAINBOW_MIKU = command.Equals("rainbow");
        DASH_MIKU = command.Equals("she walks");
        RAINBOW_ROAD_MIKU = command.Equals("rainbow road") || command.Equals("rainbow rows");
    }


}
