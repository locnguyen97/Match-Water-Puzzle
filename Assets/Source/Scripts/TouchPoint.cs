using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TouchPoint : MonoBehaviour
{

    public int id;
    [SerializeField] private List<Sprite> listWt;
    [SerializeField] private List<Sprite> listLon;
    [SerializeField] private List<Sprite> listTop;
    [SerializeField] private List<Sprite> listTt;
    private bool isSelected = false;

    private void OnEnable()
    {
        int max = GameManager.Instance.currentIndex + 1;
        id = Random.Range(0, max);
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = listWt[id];
        transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = listLon[id];
        transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = listTop[id];
        transform.GetChild(3).GetComponent<SpriteRenderer>().sprite = listTt[id];
    }

    public void SetCollected()
    {
        if(isSelected) return;
        isSelected = true;
        transform.localScale = Vector3.one*0.45f;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    public void SetUnCollected()
    {
        isSelected = false;
        transform.localScale = Vector3.one*0.4f;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}