using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager
{
    class Pool
    {
        public GameObject Original { get; private set; }
        public Transform root { get; set; }

        private Stack<Poolable> _poolStack = new Stack<Poolable>();
    }

    private Dictionary<string, Pool> _pool = new Dictionary<string, Pool>();
    private Transform _root;
    
    public void Init()
    {
        if (_root == null)
        {
            _root = new GameObject {name = "@Pool_Root"}.transform;
            Object.DontDestroyOnLoad(_root);
        }
    }

    public void Push(Poolable poolable)
    {
        
    }

    public Poolable Pop(GameObject original, Transform parent = null)
    {
        return null;
    }

    public GameObject GetOriginal(string name)
    {
        return null;
    }
}
