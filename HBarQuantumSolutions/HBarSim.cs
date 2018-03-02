using System.Collections;
using UnityEngine;
using System;

namespace HBarQuantumSolutions
{
    public class HBarSim : MonoBehaviour
    {
        #region GUI Fields
        private int PossibleHBarValues = 2;
        private string[] HBarValueNames = {"Normal", "High"};
        #endregion

        #region Draw GUI
        private void OnGUI()
        {
            GUI.Toolbar(new Rect(10, 10, 30, 60), PossibleHBarValues, HBarValueNames);
        }
        #endregion

        #region Force Calculation
        public Vector3 forceDir = UnityEngine.Random.onUnitSphere;
        
        #endregion
    }
}
