using System.Collections;
using System.Collections.Generic;
using Asteroids;
using DefaultNamespace.GameEvents;
using DefaultNamespace.ScriptableEvents;
using RuntimeSets;
using UnityEngine;
using UnityEngine.Serialization;

public class AsteroidSplitter : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private AsteroidRuntimeSet _asteroids;
    
    [Header("Config")]
    [SerializeField] private int _splitAmount = 3;
    [SerializeField] private float _minSplitSize;

    public void OnAsteroidSplit(int id)
    {
        Asteroid destroyedAsteroid = _asteroids.Get(id);
        
        if (destroyedAsteroid.Size < _minSplitSize)
            return;
        
        for (int i = 0; i < _splitAmount; i++)
        {
            var splitAstroid = Instantiate(destroyedAsteroid, destroyedAsteroid.transform.position, Quaternion.identity);
            
            splitAstroid.SetSizeParameters(destroyedAsteroid.Size / 3, destroyedAsteroid.Size / 2);
            splitAstroid.SetSize();

            _asteroids.Add(splitAstroid);
        }
    }
}
