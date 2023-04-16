using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    EgamMicrogameInstance microgameInstance;


   void Awake()
    {
        microgameInstance =
           FindObjectOfType<EgamMicrogameInstance>();
    }

    public void OnLoseCondition()
    {
        microgameInstance.LoseGame();
    }

}


// Start is called before the first frame update

