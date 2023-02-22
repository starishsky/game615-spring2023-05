using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;
    public GameObject particleEffect;
    //public AudioSource munch;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Steves Eaten: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("collectible")) {
            Instantiate(particleEffect, other.gameObject.transform.position, other.gameObject.transform.rotation);
            //munch.Play();
            Destroy(other.gameObject);
            Invoke("DestroyParticles", 3.0f);
            score += 1;
        }
    }

    void DestroyParticles()
    {
        Destroy(GameObject.FindWithTag("particles"));
    }
}
