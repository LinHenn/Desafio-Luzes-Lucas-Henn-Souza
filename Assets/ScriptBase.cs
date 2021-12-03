using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBase : MonoBehaviour
{
    public Light LightComp;    

    private int countLightType;

    //Como alterar o type
    public void ChangeLightType() 
    {
        countLightType++;
        if (countLightType > 2) countLightType = 0;

        if (countLightType == 0) LightComp.type = LightType.Directional;
        if (countLightType == 1) LightComp.type = LightType.Point;
        if (countLightType == 2) LightComp.type = LightType.Spot;
    }

    /*
     * VarLight.type = LightType.type
     * VarLight.color = Color
     * VarLight.range = float
     * VarLight.intensity = float
     */




}
