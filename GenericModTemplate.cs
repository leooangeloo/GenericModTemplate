using System;
using ICities;
using UnityEngine;
using ColossalFramework.Plugins;

namespace GenericModTemplate
{
    public class GenericModTemplate : IUserMod
    { 
        public string Name {
            get { return "Generic Mod Template"; }
        }
        public string Description {
            get { return "A generic template for user mods for Cities Skylines."; }
        }
    }

    public class Loader : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            GameObject gameObject = new GameObject("sample object");
            gameObject.AddComponent<SampleBehavior>();
        }
    }

    public class SampleBehavior : MonoBehaviour
    {
        void Start()
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Start Message!");
        }

        void Update()
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Update Message!");
        }
    }
}