using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.KeyAmount > 0)
                GameManager.Instance.EndGame(true);
            else
                Debug.Log("Dont have key");
        }
    }
}
