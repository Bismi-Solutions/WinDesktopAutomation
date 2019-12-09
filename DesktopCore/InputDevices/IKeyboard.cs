using BismiSolutions.DesktopCore.WindowsAPI;

namespace BismiSolutions.DesktopCore.InputDevices
{
    public interface IKeyboard
    {
        void Enter(string keysToType);
        void PressSpecialKey(KeyboardInput.SpecialKeys key);
        void HoldKey(KeyboardInput.SpecialKeys key);
        void LeaveKey(KeyboardInput.SpecialKeys key);
        bool CapsLockOn { get; set; }
    }
}