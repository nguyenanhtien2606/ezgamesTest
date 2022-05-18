using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    Coroutine C;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.Instance.KeyAmount < 3)
        {
            GameManager.Instance.IncreaseKeyAmount();
            gameObject.SetActive(false);
        }
    }
}
