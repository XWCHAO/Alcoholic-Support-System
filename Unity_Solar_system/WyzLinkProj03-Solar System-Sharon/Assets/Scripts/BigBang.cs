<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBang : MonoBehaviour {    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {       

    }

    void OnCollisionEnter(Collision coll)
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "FireBall")
        //{
            
        //}
        Destroy(this.gameObject);
        Destroy(col.gameObject);
    }
}



=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBang : MonoBehaviour {    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {       

    }


    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "FireBall")
        //{
            
        //}
        Destroy(this.gameObject);
        Destroy(col.gameObject);
    }
}



>>>>>>> bac4ac898b371931db9c3e58548eb7261a80addf
