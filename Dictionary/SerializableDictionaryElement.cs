using System;
using UnityEngine;

namespace SerializableCollections
{
    [Serializable]
    public class SerializableDictionaryElement<TKey, TValue>
    {
        [field: SerializeField] public TKey Key { get; private set; }
        [field: SerializeField] public TValue Value { get; private set; }
    }
}
