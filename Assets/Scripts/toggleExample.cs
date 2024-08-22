using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
namespace Samples.Editor.Controls
{
    public class ToggleExample : EditorWindow
    {
        private Toggle showToggle;
        private Toggle activateToggle;
        private Label labelToShow;
        private Button buttonToActivate;
        [MenuItem("Window/ToggleExample")]
        public static void OpenWindow()
        {
            var window = GetWindow<ToggleExample>("Controls: Toggle Sample");
            window.minSize = new Vector2(200, 170);
            EditorGUIUtility.PingObject(MonoScript.FromScriptableObject(window));
        }
        public void CreateGUI()
        {
            showToggle = new Toggle("Show dah label")
            {
                value = true
            };
            activateToggle = new Toggle("Active button")
            {
                value = true
            };
            labelToShow = new Label("This label is <sprite name = >");
            buttonToActivate = new Button(() => Debug.Log("Button pressed!"))
            {
                text = "Active if above shifuck toggle is On"
            };
            rootVisualElement.Add(showToggle);
            rootVisualElement.Add(labelToShow);
            rootVisualElement.Add(activateToggle);
            rootVisualElement.Add(buttonToActivate);
            showToggle.RegisterValueChangedCallback(evt => labelToShow.visible = evt.newValue);
            activateToggle.RegisterValueChangedCallback(evt => buttonToActivate.SetEnabled(evt.newValue));
        }
    }
}