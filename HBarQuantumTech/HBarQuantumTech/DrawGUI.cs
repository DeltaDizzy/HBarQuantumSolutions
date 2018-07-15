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
    class DrawGUI : MonoBehaviour
    {
        #region Fields
        private ApplicationLauncherButton toolbarButton;
        private Texture2D toolbarTex;
        private bool DialogWindowDisplayed;
        private PopupDialog SettingsDialog { get; set; }
        public static Vector2 AnchorMin = new Vector2(0.5f, 1f);
        public static Vector2 AnchorMax = new Vector2(0.5f, 1f);


        [KSPField(isPersistant = true)]
        private bool isHBarValueHigh = false;
        #endregion

        #region Awake
        public void Awake()
        {
            Debug.Log("[HBAR]: Awaking Instance");
            DontDestroyOnLoad(this);
        }
        #endregion

        #region Draw UI
        public void SpawnUIPopup()
        {
            PopupDialog.SpawnPopupDialog(
                AnchorMin,
                AnchorMax,
                ControlUI,
                false, 
                HBarSkinDef.HBarSkin
                );
        }

        public void AppLauncherGen()
        {
           /* if (ApplicationLauncher.Ready && toolbarButton == null)
            {
                toolbarButton =
                    ApplicationLauncher.Instance.AddModApplication(
                        onTrue: 
                        );
            }*/
        }

        MultiOptionDialog ControlUI = new MultiOptionDialog(
            "JitterControlpanel",
            "What would kind of experience would you like today? Your options are 'NONE' or 'FUN'. If you want Fun, get ready to bounce...",
            "Quantum Jitter Control Panel",
            HBarSkinDef.HBarSkin,
            new DialogGUIFlexibleSpace(),
            new DialogGUIHorizontalLayout(
                new DialogGUIFlexibleSpace(),
                new DialogGUIButton("NONE",
                    delegate
                    {
                        ModuleQuantumJiggle.isJiggleActive = false;
                        ScreenMessages.PostScreenMessage("Jiggle off. No fun, huh.", 3, ScreenMessageStyle.UPPER_CENTER);
                    }
                    ),
                new DialogGUIButton("FUN",
                    delegate
                    {
                        ModuleQuantumJiggle.isJiggleActive = true;
                        ScreenMessages.PostScreenMessage("Its time to get down! {Music Intensifies}", 3, ScreenMessageStyle.UPPER_CENTER);
                    }
                    )
                )
            );
        #endregion
    }
}
