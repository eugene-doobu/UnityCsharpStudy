using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Garbage
{
    // 1. 위치 벡터
    // 2. 방향 벡터
    struct MyVector
    {
        public float x;
        public float y;
        public float z;

        public MyVector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    
        // 피타고라스 공식 응용
        public float magnitude => Mathf.Sqrt(x*x + y*y + z*z);
        public MyVector normalized => new MyVector(x / magnitude, y / magnitude, z / magnitude);

        public static MyVector operator +(MyVector a, MyVector b)
        {
            return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static MyVector operator -(MyVector a, MyVector b)
        {
            return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static MyVector operator *(MyVector a, float b)
        {
            return new MyVector(a.x * b, a.y * b, a.z * b);
        }
    }

    public class _MyVector : MonoBehaviour
    {
        private float _speed = 4;
        
        // Local -> World
        // transform.TransformDirection()
        
        // World -> Local
        // transform.InverseTransformDirection()

        void Start()
        {
            MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
            MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
            MyVector dir = to - from; // (5, 0, 0);
            dir = dir.normalized; // (1, 0, 0)

            MyVector newPos = from + dir * _speed; // from + (_speed, 0, 0)
            // 방향 벡터
            // 1. 거리(크기)
            // 2. 실제 방향
        }
    }
}
