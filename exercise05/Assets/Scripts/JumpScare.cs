using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject EvilSteve;
    
    // Start is called before the first frame update
    void Start()
    {
        EvilSteve.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("jumpscare")) {
            EvilSteve.SetActive(true);
        }
    }
}
