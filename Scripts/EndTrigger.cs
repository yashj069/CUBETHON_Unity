using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameMananger gameMananger;
    void OnTriggerEnter(Collider other)
    {
        gameMananger.CompleteLevel();
    }
}
