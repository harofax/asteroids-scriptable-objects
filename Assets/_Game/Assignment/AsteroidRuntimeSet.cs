using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace RuntimeSets
{
    [CreateAssetMenu]
    public class AsteroidRuntimeSet : ScriptableObject
    {
        private Dictionary<int, Asteroid> _asteroids = new Dictionary<int, Asteroid>();

        private void Awake()
        {
            Clear();
        }

        public void Add(Asteroid asteroid)
        {
            _asteroids[asteroid.GetInstanceID()] = asteroid;
        }

        public void Remove(Asteroid asteroid)
        {
            _asteroids.Remove(asteroid.GetInstanceID());
        }

        public Asteroid Get(int id)
        {
            return _asteroids[id];
        }

        private void Clear()
        {
            _asteroids = new Dictionary<int, Asteroid>();
        }
    }
}