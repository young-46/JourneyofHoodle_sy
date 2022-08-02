using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        GameObject.FindWithTag("Player").GetComponent<SaveAndLoad>().Load();
        GameObject.FindWithTag("Player").GetComponent<SaveChangeState>().Load();
        gameObject.SetActive(false);
    }
}
