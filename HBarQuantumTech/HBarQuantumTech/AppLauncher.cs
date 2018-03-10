using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSP.UI.Screens;
using UnityEngine;

namespace HBarQuantumTech
{
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    class AppLauncherStuff : MonoBehaviour
    {
        private ApplicationLauncherButton toolbarButton;
        private Texture2D toolbarTex;

        public void Awake()
        {
            Debug.Log("[HBAR]: Awaking Instance");
            DontDestroyOnLoad(this);
        }

        public void AppLauncherGen()
        {
            if (ApplicationLauncher.Ready && toolbarButton == null)
            {
                //toolbarButton =
                    //ApplicationLauncher.Instance.AddModApplication();
            }
        }
    }
}
