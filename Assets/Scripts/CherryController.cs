using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{

    public ScoreManager scoreManger;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        ScoreManager.scoreManager.RaiseScore(1);

        //scoreManger.RaiseScore(1);
        //GameObject scripter = GameObject.Find("Scripter");
        //scripter.GetComponent<ScoreManager>().RaiseScore(1);

        // gameObject.SetActive(false);//desparece el objeto
        Destroy(transform.parent.gameObject);
    }
}
