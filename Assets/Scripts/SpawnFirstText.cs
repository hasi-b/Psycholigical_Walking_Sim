using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirstText : MonoBehaviour
{
    public GameObject firstText;
    public GameObject firstTrigger;
    public GameObject clock;
    public GameObject triggerDestroy;
    public GameObject firstTexts;
    public GameObject secondText;
    public GameObject secondTexts;
    Trigger tr;
    Vector3 spawnPosition = new Vector3(-0.91f, 0.46f, -13.64f);  
    public void trigDestroy()
    {
        triggerDestroy = (GameObject)Instantiate(firstTrigger, spawnPosition, transform.rotation);
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(10f);
        firstTexts=(GameObject) Instantiate(firstText, transform.position, transform.rotation);
        trigDestroy();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());

        tr = GameObject.FindGameObjectWithTag("Player").GetComponent<Trigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tr.check == 1)
        {
            secondTexts = (GameObject)Instantiate(secondText, transform.position, transform.rotation);
            trigDestroy();
            tr.check = 0;
        }
    }
}
