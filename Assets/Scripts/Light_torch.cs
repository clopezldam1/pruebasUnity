using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using LightType = UnityEngine.Experimental.GlobalIllumination.LightType;

public class Light_torch : MonoBehaviour
{
    public Light light;
    public UnityEngine.Experimental.GlobalIllumination.LightType lightType;
    public Color lightColor;
    public float intensity;
    public float radiusInner;
    public float radiusOuter;
    public AngleUnit spotAngleInner;
    public AngleUnit spotAngleOuter;
    public float falloffStrength;
    public SortingLayerRange targetSortingLayers;

    public BlendOp blendStyle = BlendOp.Multiply;
    public int lightOrder;
    // overlap operation = additive

    //NORMAL MAPS:
    // Quality = accurate;
    // Distance = 3;


    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.intensity = intensity;
        light.color = lightColor;
        lightType = GetComponent<LightType>();
        //light.type = lightType;
      
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
}
