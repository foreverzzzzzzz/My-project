using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityBase : MonoBehaviour
{
    
}

public abstract class Entity<T> : EntityBase where T : EntityBase
{
    public int a;
    public int b;
    public int c;
    public int d;
    public int e;
}
