using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinstuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnTriggerEnter2D (Collider2D other){
		Debug.Log("Triggered");
		Destroy(gameObject);
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}
