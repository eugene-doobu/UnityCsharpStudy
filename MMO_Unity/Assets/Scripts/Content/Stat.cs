using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField]
    protected int _level;
    [SerializeField]
    protected int _hp;
    [SerializeField]
    protected int _maxHp;
    [SerializeField]
    protected int _attack;
    [SerializeField]
    protected int _defense;
    [SerializeField]
    protected float _speed;
    
    public int Level
    {
        get => _level;
        set => _level = value;
    }
    public int Hp
    {
        get => _hp;
        set => _hp = value;
    }
    public int MaxHp
    {
        get => _maxHp;
        set => _maxHp = value;
    }
    public int Attack
    {
        get => _attack;
        set => _attack = value;
    }
    public int Defense
    {
        get => _defense;
        set => _defense = value;
    }
    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    private void Start()
    {
        _level = 1;
        _hp = 100;
        _maxHp = 100;
        _attack = 10;
        _defense = 5;
        _speed = 5.0f;
    }
}
