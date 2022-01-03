using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidSet : ScriptableObject
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
    
    public class AsteroidDestroyer : MonoBehaviour
    {
        [SerializeField] private AsteroidSet _asteroids;

        public void OnAsteroidHitByLaser(int asteroidId)
        {
            // Get the asteroid
            
            // Check if big or small
            
            // if small enough, we Destoy
            
            // if it's big, we split it up.
        }

        public void RegisterAsteroid(Asteroid asteroid)
        {
            
        }

        private void DestroyAsteroid(Asteroid asteroid)
        {
            //_asteroids.Remove()
        }
    }
}
