﻿using UnityEngine;

public class Info
{
    public InfoState state;
    public GameObject container;
    public virtual void OpenPanel()
    {
    }
    public virtual void ClosePanel()
    {
    }
    public bool ContainerExist()
    {
        if (container == null) return false;
        return true;
    }
}