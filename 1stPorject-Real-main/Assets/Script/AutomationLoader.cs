using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string sceneName;
    public float durationToLoad;
    void Start()
    {
        Invoke("AutoLoad", durationToLoad);
    }

    void AutoLoad()
    {
        sceneLoader.ChangeScene(sceneName);

    }

    
}
