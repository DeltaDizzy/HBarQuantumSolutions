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
        public static Vector2 SettingsAnchorMin = new Vector2(0.5f, 1f);
        public static Vector2 SettingsAnchorMax = new Vector2(0.5f, 1f);


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

        #region Draw GUI
        public void SpawnSettingsPopup()
        {
            //PopupDialog.SpawnPopupDialog();
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
        #endregion

        #region Draw Dialog
        public void DrawDialog()
        {
            if (SettingsDialog == null)
            {
                SettingsDialog = PopupDialog.SpawnPopupDialog(
                        SettingsAnchorMin,
                        SettingsAnchorMax,
                        new MultiOptionDialog("", "", null,
                            AstrogatorSkin,
                            geometry,
                            new DialogGUIHorizontalLayout()
                            {
                                OnUpdate = () => {
                                    if (needUIScaleOffsetUpdate)
                                    {
                                        needUIScaleOffsetUpdate = false;
                                        replaceScratchWindowWithRealView();
                                    }
                                }
                            }
                        ),
                        false,
                        AstrogatorSkin,
                        false
                    );
            }
        }
        #endregion  

        
    }
}
