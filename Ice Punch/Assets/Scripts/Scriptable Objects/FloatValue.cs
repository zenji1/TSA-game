﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver {

    public float initialValue;

    [HideInInspector]
    public float RuntimeValue;

    public void OnAfterDeserialize(){
        RuntimeValue = initialValue;
    }

    public void OnBeforeSerialize(){}
}