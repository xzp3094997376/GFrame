using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class EntityTes : EntityLogic
{
    // Start is called before the first frame update
    protected override void OnShow(object userData)
    {
        base.OnShow(userData);
        Log.Debug("cube loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
