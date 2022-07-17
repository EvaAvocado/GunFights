using System;
using UnityEngine;

namespace Util
{
    [Serializable]
    public class Cooldown
    {
        [SerializeField] private float _valueOfCooldown;

        private float _timesUp;

        public void Reset()
        {
            _timesUp = Time.time + _valueOfCooldown;
        }

        public bool IsReady => _timesUp <= Time.time;
    }
}