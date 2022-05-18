using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] Transform spawnPoint;

    [Space]
    [SerializeField] GameObject player;

    [Space]
    [SerializeField] UIManager uiManager;

    [Space]
    [SerializeField] GameObject key;

    public int KeyAmount
    {
        get;
        private set;
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void EndGame(bool isWin)
    {
        uiManager.ActivePanelResult(true, isWin);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    //void SpawnPlayer()
    //{
    //    player.transform.position = spawnPoint.position;
    //    player.transform.rotation = Quaternion.Euler(Vector3.zero);
    //}

    public void IncreaseKeyAmount()
    {
        if (KeyAmount < 3)
        {
            KeyAmount++;
            uiManager.ActiveKeyIcon(KeyAmount - 1);

            StartCoroutine(C_spawnKey());
        }
    }

    IEnumerator C_spawnKey()
    {
        yield return new WaitForSeconds(5);
        key.SetActive(true);
    }
}
