using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            Debug.Log("WiN");
            Manager.Instance.isWin = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            collision.gameObject.SetActive(false);
            //TODO WIN Handler
        }
    }
}
