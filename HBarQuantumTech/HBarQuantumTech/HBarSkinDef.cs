using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HBarQuantumTech
{
    class HBarSkinDef
    {
        //The actual Skin Def, but its only the tip of the iceberg
        public static readonly UISkinDef HBarSkin = new UISkinDef()
        {
            name = "HBar Quantum Solutions Skin",
            window = windowStyle,
            box = UISkinManager.defaultSkin.box,
            font = UISkinManager.defaultSkin.font,
            label = null,
            toggle = toggleStyle,
            button = UISkinManager.defaultSkin.button,
        };

        public static readonly UIStyle windowStyle = new UIStyle()
        {
            normal = windowStyleState,
            active = windowStyleState,
            disabled = windowStyleState,
            highlight = windowStyleState,
            alignment = TextAnchor.UpperCenter,
            fontSize = UISkinManager.defaultSkin.window.fontSize,
            fontStyle = FontStyle.Bold,
        };

        public static readonly Sprite halfTransparentBlack = SolidColorSprite(new Color(0f, 0f, 0f, 0.5f));

        public static readonly UIStyleState windowStyleState = new UIStyleState()
        {
            background = halfTransparentBlack,
            textColor = Color.HSVToRGB(0.3f, 0.8f, 0.8f)
        };
    } 
}
