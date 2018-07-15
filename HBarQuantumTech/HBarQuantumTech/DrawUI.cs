using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSP.UI.Screens;
using UnityEngine;

namespace HBarQuantumTech
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class AppLauncherStuff : MonoBehaviour
    {
        #region Fields
        private ApplicationLauncherButton HBarButton;
        private Texture2D toolbarTex;
        private bool DialogWindowDisplayed;
        private PopupDialog SettingsDialog { get; set; }
        public static Vector2 SettingsAnchorMin = new Vector2(0.5f, 1f);
        public static Vector2 SettingsAnchorMax = new Vector2(0.5f, 1f);

        #endregion

        #region Awake
        public void Awake()
        {
            Debug.Log("[HBAR]: Awaking Instance");
            DontDestroyOnLoad(this);
        }
        #endregion

        #region Draw AppLauncher
        public void AppLauncherGen()
        {
            if (ApplicationLauncher.Ready && HBarButton == null && HighLogic.LoadedScene == GameScenes.FLIGHT)
            {
                HBarButton =
                    ApplicationLauncher.Instance.AddModApplication(
                        onTrue:     DrawPopup,
                        onFalse:    RemoveAppButton,
                        onHover:    null,
                        onHoverOut: null,
                        onEnable:   null,
                        onDisable:  null,
                        visibleInScenes: ApplicationLauncher.AppScenes.FLIGHT,
                        texture:    GameDatabase.Instance.GetTexture("HBarQS/Icons/BoogieIcon.png", false)
                        );
            }
        }
        #endregion

        #region Draw Popup
        public void DrawPopup()
        {
            if ((HighLogic.LoadedScene == GameScenes.FLIGHT))
            {
                PopupDialog.SpawnPopupDialog(new Vector2(0.5f, 0.5f),
                    new Vector2(0.5f, 0.5f),
                    new MultiOptionDialog("",
                        "HBar Quantum Solutions",
                        HighLogic.UISkin,
                        new Rect(0.5f, 0.5f, 150f, 60f),
                        new DialogGUIFlexibleSpace(),
                        new DialogGUIVerticalLayout(
                            new DialogGUIFlexibleSpace(),
                            new DialogGUIButton("High",
                                delegate
                                {
                                    ModuleQuantumJiggle.isJiggleActive = true;
                                }, 140.0f, 30.0f, true),
                            new DialogGUIButton("Low",
                                delegate
                                {
                                    ModuleQuantumJiggle.isJiggleActive = false;
                                }, 140.0f, 30.0f, true),

                            new DialogGUIButton("Close", () => { }, 140.0f, 30.0f, true)
                            )),
                    false,
                    HighLogic.UISkin);
            }
        }

        private void RemoveAppButton()
        {
            ApplicationLauncher.Instance.RemoveModApplication(HBarButton);
        }
        #endregion

        public void HotKey_ToggleQuantumJiggle()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.S))
            {
                ModuleQuantumJiggle.isJiggleActive = true;
            }
            else
            {
                ModuleQuantumJiggle.isJiggleActive = false;
            }
        }

        private void FixedUpdate()
        {
            HotKey_ToggleQuantumJiggle();
        }
    }
}
