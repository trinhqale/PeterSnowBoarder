using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject megDeadPrefab;

    [SerializeField] private GameObject meg;
    // Start is called before the first frame update
    private void Start()
    {
        HidePrefab(megDeadPrefab);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            HidePrefab(meg);
            ShowPrefab(megDeadPrefab);
            Debug.Log("You Win!");
        }
    }

    private void HidePrefab(GameObject prefab)
    {
        if (prefab != null)
        {
            prefab.SetActive(false);
        }
    }
    private void ShowPrefab(GameObject prefab)
    {
        if (prefab != null)
        {
            prefab.SetActive(true);
        }
    }
}
