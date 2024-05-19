using System;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleEventSystem
{
    /// <summary>
    /// A Simple event manager
    /// </summary>
    public sealed class SimpleEventManager
    {
        private SimpleEventManager(){}

        private static Dictionary<string, List<Action>> _eventDictionary = new Dictionary<string, List<Action>>();

        #region AddListener
        public static void AddListener(Enum eventName, Action handler)
        {
            AddListener(eventName.ToString(), handler);
        }
        public static void AddListener(string eventName, Action handler)
        {
            if (!_eventDictionary.ContainsKey(eventName))
            {
                List<Action> newHandlerList = new List<Action>
                {
                    handler
                };
                _eventDictionary.Add(eventName, newHandlerList);
                return;
            }
            _eventDictionary[eventName].Add(handler);
        }
        #endregion

        #region RemoveListener
        public static void RemoveListener(Enum eventName, Action listener)
        {
            RemoveListener(eventName.ToString(), listener);
        }
        public static void RemoveListener(string eventName, Action listener)
        {
            if (!_eventDictionary.ContainsKey(eventName))
            {
                return;
            }
            _eventDictionary[eventName].Remove(listener);
        }
        #endregion

        #region Invoke
        public static void Invoke(Enum eventName)
        {
            Invoke(eventName.ToString());
        }
        public static void Invoke(string eventName)
        {
            if(!_eventDictionary.ContainsKey(eventName))
            {
                Debug.LogError($"No event with name [{eventName}] found.");
                return;
            }

            List<Action> handlerList = _eventDictionary[eventName];

            for (int handlerIndex = 0; handlerIndex < handlerList.Count; handlerIndex++)
            {
                Action handler = handlerList[handlerIndex];
                handler?.Invoke();
            }
            
        }
        #endregion
    }
}