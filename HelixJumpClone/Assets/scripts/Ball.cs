using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce;
    public GameObject splashPrefab;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up*jumpforce);
        GameObject splash = Instantiate(splashPrefab, transform.position+new Vector3(0f,-0.2f,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
     
        if(metarialName == "Unsafe Color (Instance)")
        {
            gm.RestartGame();
        }
        else if (metarialName == "Last Ring (Instance)")
        {
            gm.GameFinish();
        }
    }
}
