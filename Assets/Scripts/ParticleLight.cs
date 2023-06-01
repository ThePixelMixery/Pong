using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLight : MonoBehaviour
{
    Light particleLight;
    
    void Start(){
    particleLight = GetComponent<Light>();
    }
    
    // Update is called once per frame
    void Update()
    {
        particleLight.intensity -= 0.1f;
    }
}
